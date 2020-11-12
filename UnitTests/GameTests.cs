using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assessment_1___Hackers_vs_CyberCrime;

namespace UnitTests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void WinGame_CurrentRoundIs5_ReturnsTrue()
        {
            // Arrange - Preparing the Object to Test
            Game myGame = new Game();
            myGame.CurrentRound = 5;

            // Act - Running the Method to Test
            var result = myGame.WinGame();

            // Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void WinGame_CurrentRoundIsNot5_ReturnsFalse()
        {
            // Arrange - Preparing the Object to Test
            Game myGame = new Game();
            Random random = new Random();
            myGame.CurrentRound = random.Next(0, 5);

            // Act - Running the Method to Test
            var result = myGame.WinGame();

            // Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void MoveSafe_EncryptionInUse_ReturnsTrue()
        {
            // Arrange - Preparing the Object to Test
            Game myGame = new Game();
            myGame.StartGame();
            myGame.EncryptInUse = true;

            // Act - Running the Method to Test
            var result = myGame.MoveSafe();

            // Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void MoveSafe_EncryptionInUseAndCounterAttackEqualsRound_ReturnsTrue()
        {
            // Arrange - Preparing the Object to Test
            Game myGame = new Game();
            myGame.StartGame();
            myGame.EncryptInUse = true;
            myGame.CounterAttack = myGame.CurrentRound;

            // Act - Running the Method to Test
            var result = myGame.MoveSafe();

            // Assert
            Assert.IsTrue(result);


        }

        [TestMethod]
        public void MoveSafe_RoundDoesntEqualCounterAttack_ReturnsTrue()
        {
            // Arrange - Preparing the Object to Test
            Game myGame = new Game();
            myGame.StartGame();
            myGame.EncryptInUse = false;
            myGame.CounterAttack = myGame.CurrentRound + 1;

            // Act - Running the Method to Test
            var result = myGame.MoveSafe();

            // Assert
            Assert.IsTrue(result);


        }

        [TestMethod]
        public void MoveSafe_RoundEqualsCounterAttack_ReturnsFalse()
        {
            // Arrange - Preparing the Object to Test
            Game myGame = new Game();
            myGame.StartGame();
            myGame.EncryptInUse = false;
            myGame.CounterAttack = myGame.CurrentRound;

            // Act - Running the Method to Test
            var result = myGame.MoveSafe();

            // Assert
            Assert.IsFalse(result);


        }

        [TestMethod]
        public void outOfPassCheck_StillMorePassesAvailable_ReturnsFalse()
        {
            // Arrange - Preparing the Object to Test
            Game myGame = new Game();
            myGame.EncryptUses = 1;

            // Act - Running the Method to Test
            var result = myGame.outOfPassCheck();

            // Assert
            Assert.IsFalse(result);


        }

        [TestMethod]
        public void outOfPassCheck_NoMorePassesAvailable_ReturnsTrue()
        {
            // Arrange - Preparing the Object to Test
            Game myGame = new Game();
            myGame.EncryptUses = 0;

            // Act - Running the Method to Test
            var result = myGame.outOfPassCheck();

            // Assert
            Assert.IsTrue(result);


        }
    }
}
