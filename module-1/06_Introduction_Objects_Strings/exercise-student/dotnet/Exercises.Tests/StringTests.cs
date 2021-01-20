using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringTests
    {
        StringExercises exercises = new StringExercises();

        [TestMethod]
        public void HelloName()
        {
            AssertEquals("Input: HelloName(\"Bob\")", "Hello Bob!", exercises.HelloName("Bob"));
            AssertEquals("Input: HelloName(\"Alice\")", "Hello Alice!", exercises.HelloName("Alice"));
            AssertEquals("Input: HelloName(\"X\")", "Hello X!", exercises.HelloName("X"));
            AssertEquals("Input: HelloName(\"Dolly\")", "Hello Dolly!", exercises.HelloName("Dolly"));
            AssertEquals("Input: HelloName(\"Alpha\")", "Hello Alpha!", exercises.HelloName("Alpha"));
            AssertEquals("Input: HelloName(\"Omega\")", "Hello Omega!", exercises.HelloName("Omega"));
            AssertEquals("Input: HelloName(\"Goodbye\")", "Hello Goodbye!", exercises.HelloName("Goodbye"));
            AssertEquals("Input: HelloName(\"ho ho ho\")", "Hello ho ho ho!", exercises.HelloName("ho ho ho"));
            AssertEquals("Input: HelloName(\"xyz\")", "Hello xyz!", exercises.HelloName("xyz"));
            AssertEquals("Input: HelloName(\"Hello\")", "Hello Hello!", exercises.HelloName("Hello"));
        }

        [TestMethod]
        public void MakeAbba()
        {
            AssertEquals("Input: MakeAbba(\"Hi\", \"Bye\")", "HiByeByeHi", exercises.MakeAbba("Hi", "Bye"));
            AssertEquals("Input: MakeAbba(\"Yo\", \"Alice\")", "YoAliceAliceYo", exercises.MakeAbba("Yo", "Alice"));
            AssertEquals("Input: MakeAbba(\"What\", \"Up\")", "WhatUpUpWhat", exercises.MakeAbba("What", "Up"));
            AssertEquals("Input: MakeAbba(\"aaa\", \"bbb\")", "aaabbbbbbaaa", exercises.MakeAbba("aaa", "bbb"));
            AssertEquals("Input: MakeAbba(\"x\", \"y\")", "xyyx", exercises.MakeAbba("x", "y"));
            AssertEquals("Input: MakeAbba(\"x\", \"\")", "xx", exercises.MakeAbba("x", ""));
            AssertEquals("Input: MakeAbba(\"\", \"y\")", "yy", exercises.MakeAbba("", "y"));
            AssertEquals("Input: MakeAbba(\"Bo\", \"Ya\")", "BoYaYaBo", exercises.MakeAbba("Bo", "Ya"));
            AssertEquals("Input: MakeAbba(\"Ya\", \"Ya\")", "YaYaYaYa", exercises.MakeAbba("Ya", "Ya"));
        }

        [TestMethod]
        public void MakeTags()
        {
            AssertEquals("Input: MakeTags(\"i\", \"Yay\")", "<i>Yay</i>", exercises.MakeTags("i", "Yay"));
            AssertEquals("Input: MakeTags(\"i\", \"Hello\")", "<i>Hello</i>", exercises.MakeTags("i", "Hello"));
            AssertEquals("Input: MakeTags(\"cite\", \"Yay\")", "<cite>Yay</cite>", exercises.MakeTags("cite", "Yay"));
            AssertEquals("Input: MakeTags(\"address\", \"here\")", "<address>here</address>", exercises.MakeTags("address", "here"));
            AssertEquals("Input: MakeTags(\"body\", \"Heart\")", "<body>Heart</body>", exercises.MakeTags("body", "Heart"));
            AssertEquals("Input: MakeTags(\"i\", \"i\")", "<i>i</i>", exercises.MakeTags("i", "i"));
            AssertEquals("Input: MakeTags(\"i\", \"\")", "<i></i>", exercises.MakeTags("i", ""));
        }

        [TestMethod]
        public void MakeOutWord()
        {
            AssertEquals("Input: MakeOutWord(\"<<>>\", \"Yay\")", "<<Yay>>", exercises.MakeOutWord("<<>>", "Yay"));
            AssertEquals("Input: MakeOutWord(\"<<>>\", \"WooHoo\")", "<<WooHoo>>", exercises.MakeOutWord("<<>>", "WooHoo"));
            AssertEquals("Input: MakeOutWord(\"[[]]\", \"word\")", "[[word]]", exercises.MakeOutWord("[[]]", "word"));
            AssertEquals("Input: MakeOutWord(\"HHoo\", \"Hello\")", "HHHellooo", exercises.MakeOutWord("HHoo", "Hello"));
            AssertEquals("Input: MakeOutWord(\"abyz\", \"YAY\")", "abYAYyz", exercises.MakeOutWord("abyz", "YAY"));
        }

        [TestMethod]
        public void ExtraEnd()
        {
            AssertEquals("Input: ExtraEnd(\"Hello\")", "lololo", exercises.ExtraEnd("Hello"));
            AssertEquals("Input: ExtraEnd(\"ab\")", "ababab", exercises.ExtraEnd("ab"));
            AssertEquals("Input: ExtraEnd(\"Hi\")", "HiHiHi", exercises.ExtraEnd("Hi"));
            AssertEquals("Input: ExtraEnd(\"Candy\")", "dydydy", exercises.ExtraEnd("Candy"));
            AssertEquals("Input: ExtraEnd(\"Code\")", "dedede", exercises.ExtraEnd("Code"));
        }

        [TestMethod]
        public void FirstTwo()
        {
            AssertEquals("Input: FirstTwo(\"Hello\")", "He", exercises.FirstTwo("Hello"));
            AssertEquals("Input: FirstTwo(\"abcdefg\")", "ab", exercises.FirstTwo("abcdefg"));
            AssertEquals("Input: FirstTwo(\"ab\")", "ab", exercises.FirstTwo("ab"));
            AssertEquals("Input: FirstTwo(\"a\")", "a", exercises.FirstTwo("a"));
            AssertEquals("Input: FirstTwo(\"\")", "", exercises.FirstTwo(""));
            AssertEquals("Input: FirstTwo(\"Kitten\")", "Ki", exercises.FirstTwo("Kitten"));
            AssertEquals("Input: FirstTwo(\"hi\")", "hi", exercises.FirstTwo("hi"));
            AssertEquals("Input: FirstTwo(\"hiya\")", "hi", exercises.FirstTwo("hiya"));
        }

        [TestMethod]
        public void FirstHalf()
        {
            AssertEquals("Input: FirstHalf(\"WooHoo\")", "Woo", exercises.FirstHalf("WooHoo"));
            AssertEquals("Input: FirstHalf(\"HelloThere\")", "Hello", exercises.FirstHalf("HelloThere"));
            AssertEquals("Input: FirstHalf(\"abcdef\")", "abc", exercises.FirstHalf("abcdef"));
            AssertEquals("Input: FirstHalf(\"ab\")", "a", exercises.FirstHalf("ab"));
            AssertEquals("Input: FirstHalf(\"\")", "", exercises.FirstHalf(""));
            AssertEquals("Input: FirstHalf(\"0123456789\")", "01234", exercises.FirstHalf("0123456789"));
            AssertEquals("Input: FirstHalf(\"kitten\")", "kit", exercises.FirstHalf("kitten"));
        }

        [TestMethod]
        public void WithoutEnd()
        {
            AssertEquals("Input: WithoutEnd(\"Hello\")", "ell", exercises.WithoutEnd("Hello"));
            AssertEquals("Input: WithoutEnd(\"java\")", "av", exercises.WithoutEnd("java"));
            AssertEquals("Input: WithoutEnd(\"coding\")", "odin", exercises.WithoutEnd("coding"));
            AssertEquals("Input: WithoutEnd(\"code\")", "od", exercises.WithoutEnd("code"));
            AssertEquals("Input: WithoutEnd(\"Chocolate!\")", "hocolate", exercises.WithoutEnd("Chocolate!"));
            AssertEquals("Input: WithoutEnd(\"coding\")", "odin", exercises.WithoutEnd("coding"));
            AssertEquals("Input: WithoutEnd(\"kitten\")", "itte", exercises.WithoutEnd("kitten"));
            AssertEquals("Input: WithoutEnd(\"woohoo\")", "ooho", exercises.WithoutEnd("woohoo"));
        }

        [TestMethod]
        public void ComboString()
        {
            AssertEquals("Input: ComboString(\"Hello\", \"hi\")", "hiHellohi", exercises.ComboString("Hello", "hi"));
            AssertEquals("Input: ComboString(\"hi\", \"Hello\")", "hiHellohi", exercises.ComboString("hi", "Hello"));
            AssertEquals("Input: ComboString(\"aaa\", \"b\")", "baaab", exercises.ComboString("aaa", "b"));
            AssertEquals("Input: ComboString(\"b\", \"aaa\")", "baaab", exercises.ComboString("b", "aaa"));
            AssertEquals("Input: ComboString(\"aaa\", \"\")", "aaa", exercises.ComboString("aaa", ""));
            AssertEquals("Input: ComboString(\"\", \"bb\")", "bb", exercises.ComboString("", "bb"));
            AssertEquals("Input: ComboString(\"aaa\", \"1234\")", "aaa1234aaa", exercises.ComboString("aaa", "1234"));
            AssertEquals("Input: ComboString(\"aaa\", \"bb\")", "bbaaabb", exercises.ComboString("aaa", "bb"));
            AssertEquals("Input: ComboString(\"a\", \"bb\")", "abba", exercises.ComboString("a", "bb"));
            AssertEquals("Input: ComboString(\"bb\", \"a\")", "abba", exercises.ComboString("bb", "a"));
            AssertEquals("Input: ComboString(\"xyz\", \"ab\")", "abxyzab", exercises.ComboString("xyz", "ab"));
        }

        [TestMethod]
        public void NonStart()
        {
            AssertEquals("Input: NonStart(\"Hello\", \"There\")", "ellohere", exercises.NonStart("Hello", "There"));
            AssertEquals("Input: NonStart(\"java\", \"code\")", "avaode", exercises.NonStart("java", "code"));
            AssertEquals("Input: NonStart(\"shotl\", \"java\")", "hotlava", exercises.NonStart("shotl", "java"));
            AssertEquals("Input: NonStart(\"ab\", \"xy\")", "by", exercises.NonStart("ab", "xy"));
            AssertEquals("Input: NonStart(\"ab\", \"x\")", "b", exercises.NonStart("ab", "x"));
            AssertEquals("Input: NonStart(\"x\", \"ac\")", "c", exercises.NonStart("x", "ac"));
            AssertEquals("Input: NonStart(\"a\", \"x\")", "", exercises.NonStart("a", "x"));
            AssertEquals("Input: NonStart(\"kit\", \"kat\")", "itat", exercises.NonStart("kit", "kat"));
            AssertEquals("Input: NonStart(\"mart\", \"dart\")", "artart", exercises.NonStart("mart", "dart"));
        }

        [TestMethod]
        public void Left2()
        {
            AssertEquals("Input: Left2(\"Hello\")", "lloHe", exercises.Left2("Hello"));
            AssertEquals("Input: Left2(\"java\")", "vaja", exercises.Left2("java"));
            AssertEquals("Input: Left2(\"Hi\")", "Hi", exercises.Left2("Hi"));
            AssertEquals("Input: Left2(\"code\")", "deco", exercises.Left2("code"));
            AssertEquals("Input: Left2(\"cat\")", "tca", exercises.Left2("cat"));
            AssertEquals("Input: Left2(\"12345\")", "34512", exercises.Left2("12345"));
            AssertEquals("Input: Left2(\"Chocolate\")", "ocolateCh", exercises.Left2("Chocolate"));
            AssertEquals("Input: Left2(\"bricks\")", "icksbr", exercises.Left2("bricks"));
        }

        [TestMethod]
        public void Right2()
        {
            AssertEquals("Input: Right2(\"Hello\")", "loHel", exercises.Right2("Hello"));
            AssertEquals("Input: Right2(\"java\")", "vaja", exercises.Right2("java"));
            AssertEquals("Input: Right2(\"Hi\")", "Hi", exercises.Right2("Hi"));
            AssertEquals("Input: Right2(\"code\")", "deco", exercises.Right2("code"));
            AssertEquals("Input: Right2(\"cat\")", "atc", exercises.Right2("cat"));
            AssertEquals("Input: Right2(\"12345\")", "45123", exercises.Right2("12345"));
        }

        [TestMethod]
        public void TheEnd()
        {
            AssertEquals("Input: TheEnd(\"Hello\", true)", "H", exercises.TheEnd("Hello", true));
            AssertEquals("Input: TheEnd(\"Hello\", false)", "o", exercises.TheEnd("Hello", false));
            AssertEquals("Input: TheEnd(\"oh\", true)", "o", exercises.TheEnd("oh", true));
            AssertEquals("Input: TheEnd(\"oh\", false)", "h", exercises.TheEnd("oh", false));
            AssertEquals("Input: TheEnd(\"x\", true)", "x", exercises.TheEnd("x", true));
            AssertEquals("Input: TheEnd(\"x\", false)", "x", exercises.TheEnd("x", false));
            AssertEquals("Input: TheEnd(\"java\", true)", "j", exercises.TheEnd("java", true));
            AssertEquals("Input: TheEnd(\"chocolate\", false)", "e", exercises.TheEnd("chocolate", false));
            AssertEquals("Input: TheEnd(\"1234\", true)", "1", exercises.TheEnd("1234", true));
            AssertEquals("Input: TheEnd(\"code\", false)", "e", exercises.TheEnd("code", false));
        }

        [TestMethod]
        public void WithoutEnd2()
        {
            AssertEquals("Input:WithoutEnd2(\"Hello\") ", "ell", exercises.WithoutEnd2("Hello"));
            AssertEquals("Input: WithoutEnd2(\"abc\")", "b", exercises.WithoutEnd2("abc"));
            AssertEquals("Input: WithoutEnd2(\"ab\")", "", exercises.WithoutEnd2("ab"));
            AssertEquals("Input: WithoutEnd2(\"a\")", "", exercises.WithoutEnd2("a"));
            AssertEquals("Input: WithoutEnd2(\"\"))", "", exercises.WithoutEnd2(""));
            AssertEquals("Input: WithoutEnd2(\"coldy\")", "old", exercises.WithoutEnd2("coldy"));
            AssertEquals("Input: WithoutEnd2(\"java code\")", "ava cod", exercises.WithoutEnd2("java code"));
        }

        [TestMethod]
        public void MiddleTwo()
        {
            AssertEquals("Input: MiddleTwo(\"string\")", "ri", exercises.MiddleTwo("string"));
            AssertEquals("Input: MiddleTwo(\"code\")", "od", exercises.MiddleTwo("code"));
            AssertEquals("Input: MiddleTwo(\"Practice\")", "ct", exercises.MiddleTwo("Practice"));
            AssertEquals("Input: MiddleTwo(\"ab\")", "ab", exercises.MiddleTwo("ab"));
            AssertEquals("Input: MiddleTwo(\"0123456789\")", "45", exercises.MiddleTwo("0123456789"));
        }

        [TestMethod]
        public void EndsLy()
        {
            AssertEquals("Input: EndsLy(\"oddly\")", true, exercises.EndsLy("oddly"));
            AssertEquals("Input: EndsLy(\"y\")", false, exercises.EndsLy("y"));
            AssertEquals("Input: EndsLy(\"oddy\")", false, exercises.EndsLy("oddy"));
            AssertEquals("Input: EndsLy(\"oddl\")", false, exercises.EndsLy("oddl"));
            AssertEquals("Input: EndsLy(\"olydd\")", false, exercises.EndsLy("olydd"));
            AssertEquals("Input: EndsLy(\"ly\")", true, exercises.EndsLy("ly"));
            AssertEquals("Input: EndsLy(\"\")", false, exercises.EndsLy(""));
            AssertEquals("Input: EndsLy(\"falsey\")", false, exercises.EndsLy("falsey"));
            AssertEquals("Input: EndsLy(\"evenly\")", true, exercises.EndsLy("evenly"));
        }

        [TestMethod]
        public void NTwice()
        {
            AssertEquals("Input: NTwice(\"Hello\", 2)", "Helo", exercises.NTwice("Hello", 2));
            AssertEquals("Input: NTwice(\"Chocolate\", 3)", "Choate", exercises.NTwice("Chocolate", 3));
            AssertEquals("Input: NTwice(\"Chocolate\", 1)", "Ce", exercises.NTwice("Chocolate", 1));
            AssertEquals("Input: NTwice(\"Chocolate\", 0)", "", exercises.NTwice("Chocolate", 0));
            AssertEquals("Input: NTwice(\"Hello\", 4)", "Hellello", exercises.NTwice("Hello", 4));
            AssertEquals("Input: NTwice(\"Code\", 4)", "CodeCode", exercises.NTwice("Code", 4));
            AssertEquals("Input: NTwice(\"Code\", 2)", "Code", exercises.NTwice("Code", 2));
        }

        [TestMethod]
        public void TwoChar()
        {
            AssertEquals("Input: TwoChar(\"java\", 0)", "ja", exercises.TwoChar("java", 0));
            AssertEquals("Input: TwoChar(\"java\", 2)", "va", exercises.TwoChar("java", 2));
            AssertEquals("Input: TwoChar(\"java\", 3)", "ja", exercises.TwoChar("java", 3));
            AssertEquals("Input: TwoChar(\"java\", 4)", "ja", exercises.TwoChar("java", 4));
            AssertEquals("Input: TwoChar(\"java\", -1)", "ja", exercises.TwoChar("java", -1));
            AssertEquals("Input: TwoChar(\"Hello\", 0)", "He", exercises.TwoChar("Hello", 0));
            AssertEquals("Input: TwoChar(\"Hello\", 1)", "el", exercises.TwoChar("Hello", 1));
            AssertEquals("Input: TwoChar(\"Hello\", 99)", "He", exercises.TwoChar("Hello", 99));
            AssertEquals("Input: TwoChar(\"Hello\", 3)", "lo", exercises.TwoChar("Hello", 3));
            AssertEquals("Input: TwoChar(\"Hello\", 4)", "He", exercises.TwoChar("Hello", 4));
            AssertEquals("Input: TwoChar(\"Hello\", 5)", "He", exercises.TwoChar("Hello", 5));
            AssertEquals("Input: TwoChar(\"Hello\", -7)", "He", exercises.TwoChar("Hello", -7));
            AssertEquals("Input: TwoChar(\"Hello\", 6)", "He", exercises.TwoChar("Hello", 6));
            AssertEquals("Input: TwoChar(\"Hello\", -1)", "He", exercises.TwoChar("Hello", -1));
            AssertEquals("Input: TwoChar(\"yay\", 0)", "ya", exercises.TwoChar("yay", 0));
        }

        [TestMethod]
        public void MiddleThree()
        {
            AssertEquals("Input: MiddleThree(\"Candy\")", "and", exercises.MiddleThree("Candy"));
            AssertEquals("Input: MiddleThree(\"and\")", "and", exercises.MiddleThree("and"));
            AssertEquals("Input: MiddleThree(\"solving\")", "lvi", exercises.MiddleThree("solving"));
            AssertEquals("Input: MiddleThree(\"Hi yet Hi\")", "yet", exercises.MiddleThree("Hi yet Hi"));
            AssertEquals("Input: MiddleThree(\"java yet java\")", "yet", exercises.MiddleThree("java yet java"));
            AssertEquals("Input: MiddleThree(\"Chocolate\")", "col", exercises.MiddleThree("Chocolate"));
            AssertEquals("Input: MiddleThree(\"XabcxyzabcX\")", "xyz", exercises.MiddleThree("XabcxyzabcX"));
        }

        [TestMethod]
        public void HasBad()
        {
            AssertEquals("Input: HasBad(\"badxx\")", true, exercises.HasBad("badxx"));
            AssertEquals("Input: HasBad(\"xbadxx\")", true, exercises.HasBad("xbadxx"));
            AssertEquals("Input: HasBad(\"xxbadxx\")", false, exercises.HasBad("xxbadxx"));
            AssertEquals("Input: HasBad(\"code\")", false, exercises.HasBad("code"));
            AssertEquals("Input: HasBad(\"bad\")", true, exercises.HasBad("bad"));
            AssertEquals("Input: HasBad(\"ba\")", false, exercises.HasBad("ba"));
            AssertEquals("Input: HasBad(\"xba\")", false, exercises.HasBad("xba"));
            AssertEquals("Input: HasBad(\"xbad\")", true, exercises.HasBad("xbad"));
            AssertEquals("Input: HasBad(\"\")", false, exercises.HasBad(""));
            AssertEquals("Input: HasBad(\"badyy\")", true, exercises.HasBad("badyy"));
        }

        [TestMethod]
        public void StringTimes()
        {
            AssertEquals("Input: StringTimes(\"Hi\", 2)", "HiHi", exercises.StringTimes("Hi", 2));
            AssertEquals("Input: StringTimes(\"Hi\", 3)", "HiHiHi", exercises.StringTimes("Hi", 3));
            AssertEquals("Input: StringTimes(\"Hi\", 1)", "Hi", exercises.StringTimes("Hi", 1));
            AssertEquals("Input: StringTimes(\"Hi\", 0)", "", exercises.StringTimes("Hi", 0));
            AssertEquals("Input: StringTimes(\"Hi\", 5)", "HiHiHiHiHi", exercises.StringTimes("Hi", 5));
            AssertEquals("Input: StringTimes(\"Oh Boy!\", 2)", "Oh Boy!Oh Boy!", exercises.StringTimes("Oh Boy!", 2));
            AssertEquals("Input: StringTimes(\"x\", 4)", "xxxx", exercises.StringTimes("x", 4));
            AssertEquals("Input: StringTimes(\"\", 4)", "", exercises.StringTimes("", 4));
            AssertEquals("Input: StringTimes(\"code\", 2)", "codecode", exercises.StringTimes("code", 2));
            AssertEquals("Input: StringTimes(\"code\", 3)", "codecodecode", exercises.StringTimes("code", 3));
        }

        [TestMethod]
        public void FrontTimes()
        {
            AssertEquals("Input: FrontTimes(\"Chocolate\", 2)", "ChoCho", exercises.FrontTimes("Chocolate", 2));
            AssertEquals("Input: FrontTimes(\"Chocolate\", 3)", "ChoChoCho", exercises.FrontTimes("Chocolate", 3));
            AssertEquals("Input: FrontTimes(\"Abc\", 3)", "AbcAbcAbc", exercises.FrontTimes("Abc", 3));
            AssertEquals("Input: FrontTimes(\"Ab\", 4)", "AbAbAbAb", exercises.FrontTimes("Ab", 4));
            AssertEquals("Input: FrontTimes(\"A\", 4)", "AAAA", exercises.FrontTimes("A", 4));
            AssertEquals("Input: FrontTimes(\"\", 4)", "", exercises.FrontTimes("", 4));
            AssertEquals("Input: FrontTimes(\"Abc\", 0)", "", exercises.FrontTimes("Abc", 0));
        }

        [TestMethod]
        public void CountXX()
        {
            AssertEquals("Input: CountXX(\"abcxx\")", 1, exercises.CountXX("abcxx"));
            AssertEquals("Input: CountXX(\"xxx\")", 2, exercises.CountXX("xxx"));
            AssertEquals("Input: CountXX(\"xxxx\")", 3, exercises.CountXX("xxxx"));
            AssertEquals("Input: CountXX(\"\")", 0, exercises.CountXX(""));
            AssertEquals("Input: CountXX(\"Hello there\")", 0, exercises.CountXX("Hello there"));
            AssertEquals("Input: CountXX(\"Hexxo thxxe\")", 2, exercises.CountXX("Hexxo thxxe"));
            AssertEquals("Input: CountXX(\"\")", 0, exercises.CountXX(""));
            AssertEquals("Input: CountXX(\"Kittens\")", 0, exercises.CountXX("Kittens"));
            AssertEquals("Input: CountXX(\"Kittensxxx\")", 2, exercises.CountXX("Kittensxxx"));
        }

        [TestMethod]
        public void DoubleX()
        {
            AssertEquals("Input: DoubleX(\"axxbb\")", true, exercises.DoubleX("axxbb"));
            AssertEquals("Input: DoubleX(\"axaxax\")", false, exercises.DoubleX("axaxax"));
            AssertEquals("Input: DoubleX(\"xxxxx\")", true, exercises.DoubleX("xxxxx"));
            AssertEquals("Input: DoubleX(\"xaxxx\")", false, exercises.DoubleX("xaxxx"));
            AssertEquals("Input: DoubleX(\"aaaax\")", false, exercises.DoubleX("aaaax"));
            AssertEquals("Input: DoubleX(\"\")", false, exercises.DoubleX(""));
            AssertEquals("Input: DoubleX(\"abc\")", false, exercises.DoubleX("abc"));
            AssertEquals("Input: DoubleX(\"x\")", false, exercises.DoubleX("x"));
            AssertEquals("Input: DoubleX(\"xx\")", true, exercises.DoubleX("xx"));
            AssertEquals("Input: DoubleX(\"xax\")", false, exercises.DoubleX("xax"));
            AssertEquals("Input: DoubleX(\"xaxx\")", false, exercises.DoubleX("xaxx"));
        }

        [TestMethod]
        public void StringBits()
        {
            AssertEquals("Input: StringBits(\"Hello\")", "Hlo", exercises.StringBits("Hello"));
            AssertEquals("Input: StringBits(\"Hi\")", "H", exercises.StringBits("Hi"));
            AssertEquals("Input: StringBits(\"Heeololeo\")", "Hello", exercises.StringBits("Heeololeo"));
            AssertEquals("Input: StringBits(\"HiHiHi\")", "HHH", exercises.StringBits("HiHiHi"));
            AssertEquals("Input: StringBits(\"\")", "", exercises.StringBits(""));
            AssertEquals("Input: StringBits(\"Greetings\")", "Getns", exercises.StringBits("Greetings"));
            AssertEquals("Input: StringBits(\"Chocoate\")", "Coot", exercises.StringBits("Chocoate"));
            AssertEquals("Input: StringBits(\"pi\")", "p", exercises.StringBits("pi"));
            AssertEquals("Input: StringBits(\"Hello Kitten\")", "HloKte", exercises.StringBits("Hello Kitten"));
            AssertEquals("Input: StringBits(\"hxaxpxpxy\")", "happy", exercises.StringBits("hxaxpxpxy"));
        }

        [TestMethod]
        public void StringSplosion()
        {
            AssertEquals("Input: StringSplosion(\"Code\")", "CCoCodCode", exercises.StringSplosion("Code"));
            AssertEquals("Input: StringSplosion(\"abc\")", "aababc", exercises.StringSplosion("abc"));
            AssertEquals("Input: StringSplosion(\"abc\")", "aab", exercises.StringSplosion("ab"));
            AssertEquals("Input: StringSplosion(\"x\")", "x", exercises.StringSplosion("x"));
            AssertEquals("Input: StringSplosion(\"fade\")", "ffafadfade", exercises.StringSplosion("fade"));
            AssertEquals("Input: StringSplosion(\"There\")", "TThTheTherThere", exercises.StringSplosion("There"));
            AssertEquals("Input: StringSplosion(\"Kitten\")", "KKiKitKittKitteKitten", exercises.StringSplosion("Kitten"));
            AssertEquals("Input: StringSplosion(\"Bye\")", "BByBye", exercises.StringSplosion("Bye"));
            AssertEquals("Input: StringSplosion(\"Good\")", "GGoGooGood", exercises.StringSplosion("Good"));
            AssertEquals("Input: StringSplosion(\"Bad\")", "BBaBad", exercises.StringSplosion("Bad"));
        }

        [TestMethod]
        public void Last2()
        {
            AssertEquals("Input: Last2(\"hixxhi\")", 1, exercises.Last2("hixxhi"));
            AssertEquals("Input: Last2(\"xaxxaxaxx\")", 1, exercises.Last2("xaxxaxaxx"));
            AssertEquals("Input: Last2(\"axxxaaxx\")", 2, exercises.Last2("axxxaaxx"));
            AssertEquals("Input: Last2(\"xxaxxaxxaxx\")", 3, exercises.Last2("xxaxxaxxaxx"));
            AssertEquals("Input: Last2(\"xaxaxaxx\")", 0, exercises.Last2("xaxaxaxx"));
            AssertEquals("Input: Last2(\"xxxx\")", 2, exercises.Last2("xxxx"));
            AssertEquals("Input: Last2(\"13121312\")", 1, exercises.Last2("13121312"));
            AssertEquals("Input: Last2(\"11212\")", 1, exercises.Last2("11212"));
            AssertEquals("Input: Last2(\"13121311\")", 0, exercises.Last2("13121311"));
            AssertEquals("Input: Last2(\"1717171\")", 2, exercises.Last2("1717171"));
            AssertEquals("Input: Last2(\"hi\")", 0, exercises.Last2("hi"));
            AssertEquals("Input: Last2(\"h\")", 0, exercises.Last2("h"));
            AssertEquals("Input: Last2(\"\")", 0, exercises.Last2(""));
        }

        [TestMethod]
        public void StringX()
        {
            AssertEquals("Input: StringX(\"xxHxix\")", "xHix", exercises.StringX("xxHxix"));
            AssertEquals("Input: StringX(\"abxxxcd\")", "abcd", exercises.StringX("abxxxcd"));
            AssertEquals("Input: StringX(\"xabxxxcdx\")", "xabcdx", exercises.StringX("xabxxxcdx"));
            AssertEquals("Input: StringX(\"xKittenx\")", "xKittenx", exercises.StringX("xKittenx"));
            AssertEquals("Input: StringX(\"Hello\")", "Hello", exercises.StringX("Hello"));
            AssertEquals("Input: StringX(\"xx\")", "xx", exercises.StringX("xx"));
            AssertEquals("Input: StringX(\"x\")", "x", exercises.StringX("x"));
            AssertEquals("Input: StringX(\"\")", "", exercises.StringX(""));
        }

        [TestMethod]
        public void AltPairs()
        {
            AssertEquals("Input: AltPairs(\"kitten\")", "kien", exercises.AltPairs("kitten"));
            AssertEquals("Input: AltPairs(\"Chocolate\")", "Chole", exercises.AltPairs("Chocolate"));
            AssertEquals("Input: AltPairs(\"CodingHorror\")", "Congrr", exercises.AltPairs("CodingHorror"));
            AssertEquals("Input: AltPairs(\"yak\")", "ya", exercises.AltPairs("yak"));
            AssertEquals("Input: AltPairs(\"ya\")", "ya", exercises.AltPairs("ya"));
            AssertEquals("Input: AltPairs(\"y\")", "y", exercises.AltPairs("y"));
            AssertEquals("Input: AltPairs(\"\")", "", exercises.AltPairs(""));
            AssertEquals("Input: AltPairs(\"ThisThatTheOther\")", "ThThThth", exercises.AltPairs("ThisThatTheOther"));
        }

        [TestMethod]
        public void StringYak()
        {
            AssertEquals("Input: StringYak(\"yakpak\")", "pak", exercises.StringYak("yakpak"));
            AssertEquals("Input: StringYak(\"pakyak\")", "pak", exercises.StringYak("pakyak"));
            AssertEquals("Input: StringYak(\"yak123ya\")", "123ya", exercises.StringYak("yak123ya"));
            AssertEquals("Input: StringYak(\"yak\")", "", exercises.StringYak("yak"));
            AssertEquals("Input: StringYak(\"yakxxxyak\")", "xxx", exercises.StringYak("yakxxxyak"));
            AssertEquals("Input: StringYak(\"HiyakHi\")", "HiHi", exercises.StringYak("HiyakHi"));
            AssertEquals("Input: StringYak(\"xxxyakyyyakzzz\")", "xxxyyzzz", exercises.StringYak("xxxyakyyyakzzz"));
        }

        public void AssertEquals(string message, string expected, string actual)
        {
            Assert.AreEqual(expected, actual, message);
        }

        public void AssertEquals(string message, bool expected, bool actual)
        {
            Assert.AreEqual(expected, actual, message);
        }

        public void AssertEquals(string message, int expected, int actual)
        {
            Assert.AreEqual(expected, actual, message);
        }
    }
}
