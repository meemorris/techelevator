package com.techelevator.dao;

import com.techelevator.model.Question;
import com.techelevator.model.User;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.support.rowset.SqlRowSet;
import org.springframework.stereotype.Component;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

@Component  //dependency injection - if there's a controller w a QuestionDAO parameter in the constructor, instantiate this
public class QuestionSqlDAO implements  QuestionDAO{
    private JdbcTemplate jdbcTemplate; //we've moved the login info into application.properties.

    public QuestionSqlDAO(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public List<Question> getAllQuestions() {
        List<Question> list = new ArrayList<>();
        String sql = "select title, question_id, question from questions;";

        SqlRowSet results = jdbcTemplate.queryForRowSet(sql);
        while(results.next()) {
            Question q = mapRowToQuestion(results);
            list.add(q);
        }

        return list;
    }

    @Override
    public Question getRandomQuestion() {
        List<Question> list = new ArrayList<>();
        String sql = "select title, question_id, question from questions;";

        SqlRowSet results = jdbcTemplate.queryForRowSet(sql);
        while(results.next()) {
            Question q = mapRowToQuestion(results);
            list.add(q);
        }
        Random r = new Random();
        return list.get(r.nextInt(list.size())); //it's a bit inefficient to do it this way but it's 5:30pm and we're reviewing tomorrow

    }

    @Override
    public boolean updateQuestion(Question q, int id) {
        String sql = "update questions set title=?,question=? where question_id = ?";
        int count = jdbcTemplate.update(sql,q.getTitle(),q.getQuestion(),id);
        return count==1; //we should update exactly one
    }

    @Override
    public boolean deleteQuestion(int id) {
        String sql = "delete from question  where question_id = ?";
        int count = jdbcTemplate.update(sql,id);
        return count==1; //we should update exactly one
    }

    private Question mapRowToQuestion(SqlRowSet results) {
        Question q = new Question();
        q.setTitle(results.getString("title"));
        q.setId(results.getLong("question_id"));
        q.setQuestion(results.getString("question"));
        return q;
    }
}
