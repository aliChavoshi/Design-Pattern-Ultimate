using DesignPatterns.chainOfResponsibility;
using DesignPatterns.visitor;

var document = new HtmlDocument();
document.Add(new AnchorNode());
document.Add(new HeadingNode());
document.Highlight();