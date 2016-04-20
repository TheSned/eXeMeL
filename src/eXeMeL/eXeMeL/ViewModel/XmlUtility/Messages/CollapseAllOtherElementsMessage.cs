namespace eXeMeL.ViewModel.UtilityOperationMessages
{
  internal class CollapseAllOtherElementsMessage : BaseUtilityElementMessage
  {
    public CollapseAllOtherElementsMessage(ElementViewModel element) : base(element) { }
  }



  internal class ExpandAllChildElementsMessage : BaseUtilityElementMessage
  {
    public ExpandAllChildElementsMessage(ElementViewModel element) : base(element) { }
  }



  internal class FindXPathFromRootMessage : BaseUtilityElementMessage
  {
    public FindXPathFromRootMessage(ElementViewModel element) : base(element) { }
  }


  internal class ReplaceXPathMessage : BaseUtilityXPathMessage
  {
    public ReplaceXPathMessage(string xpath) : base(xpath) { }
  }



  internal abstract class BaseUtilityElementMessage : BaseUtilityMessage<ElementViewModel>
  {
    public ElementViewModel Element {
      get { return this.Value; }
      set { this.Value = value; }
    }

    protected BaseUtilityElementMessage(ElementViewModel element) : base(element) { }
  }



  internal abstract class BaseUtilityXPathMessage : BaseUtilityMessage<string>
  {
    public string XPath
    {
      get { return this.Value; }
      set { this.Value = value; }
    }

    protected BaseUtilityXPathMessage(string xPath) : base(xPath) { }
  }



  internal abstract class BaseUtilityMessage<T>
  {
    public T Value { get; set; }



    protected BaseUtilityMessage(T value)
    {
      this.Value = value;
    }
  }
}