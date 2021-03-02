package com.techelevator.controller;

import com.techelevator.dao.QuestionDAO;
import com.techelevator.dao.UserDAO;
import com.techelevator.model.Question;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;

import java.security.Principal;
import java.util.List;

@RestController
@PreAuthorize("isAuthenticated()") //you must be authenticated to do anything
public class QuestionController {
    private QuestionDAO questionDAO;

    public QuestionController(QuestionDAO dao){
        questionDAO = dao;
    }

    @PreAuthorize("permitAll") //just this one is allowed for anonymous users
    @RequestMapping(path="question/random",method = RequestMethod.GET)
    public Question getRandomQuestion (){
        return questionDAO.getRandomQuestion();
    }

    @RequestMapping(path="question/list",method = RequestMethod.GET)
    public List<Question> getAllQuestions (Principal p){
        return questionDAO.getAllQuestions();
    }
    @RequestMapping(path="question/{id}",method = RequestMethod.PUT)
    public void updateQuestion (Principal p, @PathVariable int id, @RequestBody Question q){
        if (questionDAO.updateQuestion(q,id))
            System.out.println(p.getName()+" succussfully updated "+id);//just print to console on server, not telling client
        else
            System.out.println("There was an issue updating question "+id);
    }

    @RequestMapping(path="question/{id}",method = RequestMethod.DELETE)
    public void updateQuestion (Principal p, @PathVariable int id){
        if (questionDAO.deleteQuestion(id))
            System.out.println(p.getName()+" succussfully deleted "+id);//just print to console on server, not telling client
        else
            System.out.println("There was an issue deleting question "+id);
    }
}
