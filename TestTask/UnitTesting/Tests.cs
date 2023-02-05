using NUnit.Framework;
using TestTask;

namespace UnitTesting
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GetUniqueCharFromText_DeleteDuplicatedSymbolsInText_ReturnsChar_Lorem5()
        {
            // Arrange
            string _textToAnalyze = "Lorem ipsum dolor sit amet.";

            char _expected = 'l';
            char _actual;
            
            var uniqueCharFinder = new UniqueCharFinder();

            // Act
            _actual = uniqueCharFinder.FindFirstUniqueCharInText(_textToAnalyze);

            //Assert
            Assert.AreEqual(_expected, _actual);
        }
        
        [Test]
        public void GetUniqueCharFromText_DeleteDuplicatedSymbolsInText_ReturnsChar_Lorem10()
        {
            // Arrange
            string _textToAnalyze = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui.";

            char _expected = 'l';
            char _actual;
            
            var uniqueCharFinder = new UniqueCharFinder();

            // Act
            _actual = uniqueCharFinder.FindFirstUniqueCharInText(_textToAnalyze);

            //Assert
            Assert.AreEqual(_expected, _actual);
        }
        
        [Test]
        public void GetUniqueCharFromText_DeleteDuplicatedSymbolsInText_ReturnsChar_Lorem11()
        {
            // Arrange
            string _textToAnalyze = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui. Lorem";

            char _expected = 'i';
            char _actual;
            
            var uniqueCharFinder = new UniqueCharFinder();

            // Act
            _actual = uniqueCharFinder.FindFirstUniqueCharInText(_textToAnalyze);

            //Assert
            Assert.AreEqual(_expected, _actual);
        }
        
        [Test]
        public void GetUniqueCharFromText_DeleteDuplicatedSymbolsInText_ReturnsChar_TestText()
        {
            // Arrange
            string _textToAnalyze = "The Tao gave birth to machine language. Machine language " +
                                    "gave birth to the assembler. The assembler gave birth to " +
                                    "the compiler. Now there are ten thousand languages. " +
                                    "Each language has its purpose, however humble. Each " +
                                    "language expresses the Yin and Yang of software. " +
                                    "Each language has its place within the Tao. " +
                                    "But do not program in COBOL if you can avoid " +
                                    "it. -- Geoffrey James, 'The Tao of Programming'";

            char _expected = 'u';
            char _actual;
            
            var uniqueCharFinder = new UniqueCharFinder();

            // Act
            _actual = uniqueCharFinder.FindFirstUniqueCharInText(_textToAnalyze);

            //Assert
            Assert.AreEqual(_expected, _actual);
        }
    }
}