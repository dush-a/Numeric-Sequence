﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestNumericSequence
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Enter 5
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            HtmlEdit uIEnteranintegerEdit = this.UIHomePageNumericSequeWindow.UIHomePageNumericSequeDocument.UIEnteranintegerEdit;
            #endregion

            // Type '5' in 'Enter an integer' text box
            uIEnteranintegerEdit.Text = this.RecordedMethod1Params.UIEnteranintegerEditText;

            // Type '{Enter}' in 'Enter an integer' text box
            Keyboard.SendKeys(uIEnteranintegerEdit, this.RecordedMethod1Params.UIEnteranintegerEditSendKeys, ModifierKeys.None);
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public UIHomePageNumericSequeWindow UIHomePageNumericSequeWindow
        {
            get
            {
                if ((this.mUIHomePageNumericSequeWindow == null))
                {
                    this.mUIHomePageNumericSequeWindow = new UIHomePageNumericSequeWindow();
                }
                return this.mUIHomePageNumericSequeWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private UIHomePageNumericSequeWindow mUIHomePageNumericSequeWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Type '5' in 'Enter an integer' text box
        /// </summary>
        public string UIEnteranintegerEditText = "5";
        
        /// <summary>
        /// Type '{Enter}' in 'Enter an integer' text box
        /// </summary>
        public string UIEnteranintegerEditSendKeys = "{Enter}";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHomePageNumericSequeWindow : BrowserWindow
    {
        
        public UIHomePageNumericSequeWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Home Page - Numeric Sequence Calculator";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHomePageNumericSequeDocument UIHomePageNumericSequeDocument
        {
            get
            {
                if ((this.mUIHomePageNumericSequeDocument == null))
                {
                    this.mUIHomePageNumericSequeDocument = new UIHomePageNumericSequeDocument(this);
                }
                return this.mUIHomePageNumericSequeDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHomePageNumericSequeDocument mUIHomePageNumericSequeDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHomePageNumericSequeDocument : HtmlDocument
    {
        
        public UIHomePageNumericSequeDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home Page - Numeric Sequence Calculator";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:22429/";
            this.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UIEnteranintegerEdit
        {
            get
            {
                if ((this.mUIEnteranintegerEdit == null))
                {
                    this.mUIEnteranintegerEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIEnteranintegerEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "InputNumber";
                    this.mUIEnteranintegerEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "InputNumber";
                    this.mUIEnteranintegerEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Enter an integer";
                    this.mUIEnteranintegerEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIEnteranintegerEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIEnteranintegerEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control text-box single-line";
                    this.mUIEnteranintegerEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"InputNumber\" class=\"form-control t";
                    this.mUIEnteranintegerEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "2";
                    this.mUIEnteranintegerEdit.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
                    #endregion
                }
                return this.mUIEnteranintegerEdit;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUIEnteranintegerEdit;
        #endregion
    }
}
