using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Selenium_QA_11
{
    internal class SelectElement
    {
        private IWebElement select_box;
        internal readonly IList<IWebElement> Options;

        public SelectElement(IWebElement select_box)
        {
            this.select_box = select_box;
        }

        public bool IsMultiple { get; internal set; }

        internal void SelectByText(string v)
        {
            throw new NotImplementedException();
        }

        internal void SelectByIndex(int v)
        {
            throw new NotImplementedException();
        }

        internal void SelectByValue(string v)
        {
            throw new NotImplementedException();
        }

        internal void DeselectByIndex(int v)
        {
            throw new NotImplementedException();
        }
    }
}