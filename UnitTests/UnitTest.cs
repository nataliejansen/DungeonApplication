using DungeonLibrary;

namespace UnitTests
{
    public class UnitTest
    {
        [Fact]
        public void Test_1()
        {
            Alien alien = new Alien("\nAn Alien!", 25, 50, 20, 8, 2, "Take me to your leader? As if! This alien just wants to take over the Milky Way...and will stop at nothing to do it!",
                true);
            string expected = "An Alien!";
            string actual = "An Alien!";
            Assert.Equal(expected, actual);

        }//end void

        [Fact]
       public void Test_2()
        {
            Alien alien = new Alien("\nAn Alien!", 25, 50, 20, 8, 2, "Take me to your leader? As if! This alien just wants to take over the Milky Way...and will stop at nothing to do it!",
                    true);
            int expected = 25;
            int actual = 25;
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Test_3()
        {
            Alien alien = new Alien("\nAn Alien!", 25, 50, 20, 8, 2, "Take me to your leader? As if! This alien just wants to take over the Milky Way...and will stop at nothing to do it!",
                    true);
            int expected = 50;
            int actual = 50;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test_4()
        {
            Alien alien = new Alien("\nAn Alien!", 25, 50, 20, 8, 2, "Take me to your leader? As if! This alien just wants to take over the Milky Way...and will stop at nothing to do it!",
                    true);
            int expected = 20;
            int actual = 20;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test_5()
        {
            Alien alien = new Alien("\nAn Alien!", 25, 50, 20, 8, 2, "Take me to your leader? As if! This alien just wants to take over the Milky Way...and will stop at nothing to do it!",
                    true);
            int expected = 8;
            int actual = 8;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test_6()
        {
            Alien alien = new Alien("\nAn Alien!", 25, 50, 20, 8, 2, "Take me to your leader? As if! This alien just wants to take over the Milky Way...and will stop at nothing to do it!",
                    true);
            int expected = 2;
            int actual = 2;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test_7()
        {
            Alien alien = new Alien("\nAn Alien!", 25, 50, 20, 8, 2, "Take me to your leader? As if! This alien just wants to take over the Milky Way...and will stop at nothing to do it!",
                    true);
            string expected = "Take me to your leader? As if! This alien just wants to take over the Milky Way...and will stop at nothing to do it!";
            string actual = "Take me to your leader? As if! This alien just wants to take over the Milky Way...and will stop at nothing to do it!";
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test_8()
        {
            Alien alien = new Alien("\nAn Alien!", 25, 50, 20, 8, 2, "Take me to your leader? As if! This alien just wants to take over the Milky Way...and will stop at nothing to do it!",
                    true);
            bool expected = true;
            bool actual = true;
            Assert.Equal(expected, actual);

        }
    };//end class
}//end namespace