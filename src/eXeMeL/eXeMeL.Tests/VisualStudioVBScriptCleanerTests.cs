using eXeMeL.ViewModel.XmlCleaners;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eXeMeL.Tests
{
  [TestClass]
  public class VisualStudioVBScriptCleanerTests
  {
    [TestMethod]
    public void CleanXml_NonEscapedEmptyXmlAttribute_ShouldNotReplaceDoubleQuotes()
    {
      const string sample = "<xml attr=\"\" />";
      var context = new XmlCleanerContext() { XmlToClean = sample };

      var sut = new VisualStudioVBScriptCleaner();
      sut.CleanXml(context);

      Assert.AreEqual(sample, context.XmlToClean);
    }

    [TestMethod]
    public void CleanXml_NonEscapedEmptyXmlAttributeWithSeparateClosingTag_ShouldNotReplaceDoubleQuotes()
    {
      const string sample = "<xml attr=\"\" ></xml>";
      var context = new XmlCleanerContext() { XmlToClean = sample };

      var sut = new VisualStudioVBScriptCleaner();
      sut.CleanXml(context);

      Assert.AreEqual(sample, context.XmlToClean);
    }

    [TestMethod]
    public void CleanXml_NonEscapedEmptyXmlAttributeWithNoWhitespaceAfter_ShouldNotReplaceDoubleQuotes()
    {
      const string sample = "<xml attr=\"\"/>";
      var context = new XmlCleanerContext() { XmlToClean = sample };

      var sut = new VisualStudioVBScriptCleaner();
      sut.CleanXml(context);

      Assert.AreEqual(sample, context.XmlToClean);
    }

    [TestMethod]
    public void CleanXml_NonEscapedEmptyXmlAttributeWithNoWhitespaceAfterWithSeparateClosingTag_ShouldNotReplaceDoubleQuotes()
    {
      const string sample = "<xml attr=\"\"></xml>";
      var context = new XmlCleanerContext() { XmlToClean = sample };

      var sut = new VisualStudioVBScriptCleaner();
      sut.CleanXml(context);

      Assert.AreEqual(sample, context.XmlToClean);
    }

    [TestMethod]
    public void CleanXml_EscapedEmptyXmlAttribute_ShouldReplaceDoubleQuotes()
    {
      const string sample = "<xml attr=\"\"\"\" />";
      const string expected = "<xml attr=\"\" />";
      var context = new XmlCleanerContext() { XmlToClean = sample };

      var sut = new VisualStudioVBScriptCleaner();
      sut.CleanXml(context);

      Assert.AreEqual(expected, context.XmlToClean);
    }

    [TestMethod]
    public void CleanXml_EscapedEmptyXmlAttributeWithSeparateClosingTag_ShouldReplaceDoubleQuotes()
    {
      const string sample = "<xml attr=\"\"\"\" ></xml>";
      const string expected = "<xml attr=\"\" ></xml>";
      var context = new XmlCleanerContext() { XmlToClean = sample };

      var sut = new VisualStudioVBScriptCleaner();
      sut.CleanXml(context);

      Assert.AreEqual(expected, context.XmlToClean);
    }

    [TestMethod]
    public void CleanXml_EscapedNonEmptyXmlAttribute_ShouldReplaceDoubleQuotes()
    {
      const string sample = "<xml attr=\"\"Test\"\" />";
      const string expected = "<xml attr=\"Test\" />";
      var context = new XmlCleanerContext() { XmlToClean = sample };

      var sut = new VisualStudioVBScriptCleaner();
      sut.CleanXml(context);

      Assert.AreEqual(expected, context.XmlToClean);
    }

    [TestMethod]
    public void CleanXml_EscapedNonEmptyXmlAttributeWithSeparateClosingTag_ShouldReplaceDoubleQuotes()
    {
      const string sample = "<xml attr=\"\"Test\"\" ></xml>";
      const string expected = "<xml attr=\"Test\" ></xml>";
      var context = new XmlCleanerContext() { XmlToClean = sample };

      var sut = new VisualStudioVBScriptCleaner();
      sut.CleanXml(context);

      Assert.AreEqual(expected, context.XmlToClean);
    }

    [TestMethod]
    public void CleanXml_EscapedNonEmptyXmlAttributeWithNoWhitespaceAfter_ShouldReplaceDoubleQuotes()
    {
      const string sample = "<xml attr=\"\"Test\"\"/>";
      const string expected = "<xml attr=\"Test\"/>";
      var context = new XmlCleanerContext() { XmlToClean = sample };

      var sut = new VisualStudioVBScriptCleaner();
      sut.CleanXml(context);

      Assert.AreEqual(expected, context.XmlToClean);
    }

    [TestMethod]
    public void CleanXml_EscapedNonEmptyXmlAttributeWithNoWhitespaceAfterWithSeparateClosingTag_ShouldReplaceDoubleQuotes()
    {
      const string sample = "<xml attr=\"\"Test\"\"></xml>";
      const string expected = "<xml attr=\"Test\"></xml>";
      var context = new XmlCleanerContext() { XmlToClean = sample };

      var sut = new VisualStudioVBScriptCleaner();
      sut.CleanXml(context);

      Assert.AreEqual(expected, context.XmlToClean);
    }

    [TestMethod]
    public void CleanXml_EscapedNonEmptyXmlAttributeSurroundedBySingleQuotes_ShouldReplaceDoubleQuotes()
    {
      const string sample = "<xml attr='Test \"\"THE\"\" thing.' />";
      const string expected = "<xml attr='Test \"THE\" thing.' />";
      var context = new XmlCleanerContext() { XmlToClean = sample };

      var sut = new VisualStudioVBScriptCleaner();
      sut.CleanXml(context);

      Assert.AreEqual(expected, context.XmlToClean);
    }
  }
}
