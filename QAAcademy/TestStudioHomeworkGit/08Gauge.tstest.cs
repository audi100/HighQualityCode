using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace TestStudioHomework
{

    //
    // You can add custom execution steps by simply
    // adding a void function and decorating it with the [CodedStep] 
    // attribute to the test method. 
    // Those steps will automatically show up in the test steps on save.
    //
    // The BaseWebAiiTest exposes all key objects that you can use
    // to access the current testcase context. [i.e. ActiveBrowser, Find ..etc]
    //
    // Data driven tests can use the Data[columnIndex] or Data["columnName"] 
    // to access data for a specific data iteration.
    //
    // Example:
    //
    // [CodedStep("MyCustom Step Description")]
    // public void MyCustomStep()
    // {
    //        // Custom code goes here
    //      ActiveBrowser.NavigateTo("http://www.google.com");
    //
    //        // Or
    //        ActiveBrowser.NavigateTo(Data["url"]);
    // }
    //
        

    public class _8Gauge : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        //[CodedStep(@"Verify 'CurrentDateblock' text Same 'JUN 14, 2013'", RequiresSilverlight=true)]
        //public void Gauge_CodedStep()
        //{
            //// Verify 'CurrentDateblock' text Same 'JUN 14, 2013'
            //Assert.IsFalse((ArtOfTest.Common.CompareUtils.StringCompare(Pages.TelerikGaugeForSilverlight0.SilverlightApp.CurrentDateblock.Text, "JUN 14, 2013", ArtOfTest.Common.StringCompareType.Same) == false), string.Format("Verify \'CurrentDateblock\' text Same \'JUN 14, 2013\' failed.  Actual value \'{0}\'", Pages.TelerikGaugeForSilverlight0.SilverlightApp.CurrentDateblock.Text));
            
        //}
    
        //[CodedStep(@"Verify 'CurrentDateblock' text Same 'JUN 14, 2013', RequiresSilverlight=True")]
        //public void Gauge_CodedStep1()
        //{
            //// Verify 'CurrentDateblock' text Same 'JUN 14, 2013'
            //Assert.IsFalse((ArtOfTest.Common.CompareUtils.StringCompare(Pages.TelerikGaugeForSilverlight0.SilverlightApp.CurrentDateblock.Text, "JUN 14, 2013", ArtOfTest.Common.StringCompareType.Same) == false), string.Format("Verify \'CurrentDateblock\' text Same \'JUN 14, 2013\' failed.  Actual value \'{0}\'", Pages.TelerikGaugeForSilverlight0.SilverlightApp.CurrentDateblock.Text));
            
        //}
    
        //[CodedStep(@"Verify 'CurrentDateblock' text Same 'JUN 14, 2013'", RequiresSilverlight=true)]
        //public void Gauge_CodedStep()
        //{
            //// Verify 'CurrentDateblock' text Same 'JUN 14, 2013'
            //Assert.IsFalse((ArtOfTest.Common.CompareUtils.StringCompare(Pages.TelerikGaugeForSilverlight0.SilverlightApp.CurrentDateblock.Text, "JUN 14, 2013", ArtOfTest.Common.StringCompareType.Same) == false), string.Format("Verify \'CurrentDateblock\' text Same \'JUN 14, 2013\' failed.  Actual value \'{0}\'", Pages.TelerikGaugeForSilverlight0.SilverlightApp.CurrentDateblock.Text));
            
        //}
    
        //[CodedStep(@"New Coded Step")]
        //public void Gauge_CodedStep1()
        //{
            //string computerDate = DateTime.Now.ToString( "MMM dd, yyyy").ToUpper();
            //Assert.IsFalse((ArtOfTest.Common.CompareUtils.StringCompare(DateOnPage, computerDate, ArtOfTest.Common.StringCompareType.Same) == false), string.Format("Verify \'CurrentDateblock\' text Same "+computerDate+ " failed.  Actual value \'{0}\'", Pages.TelerikGaugeForSilverlight0.SilverlightApp.CurrentDateblock.Text));
            
        //}
    
        //[CodedStep(@"New Coded Step")]
        //public void Gauge_CodedStep()
        //{
            //string computerDate = DateTime.Now.ToString( "MMMM dd, yyyy");
            //Assert.IsFalse((ArtOfTest.Common.CompareUtils.StringCompare(Pages.TelerikGaugeForSilverlight0.SilverlightApp.CurrentDateblock.Text, computerDate, ArtOfTest.Common.StringCompareType.Same) == false), string.Format("Verify \'CurrentDateblock\' text Same \'JUN 14, 2013\' failed.  Actual value \'{0}\'", Pages.TelerikGaugeForSilverlight0.SilverlightApp.CurrentDateblock.Text));
            
        //}
    
        //[CodedStep(@"Verify 'ControlNameTextblock' text Same 'Gauge'", RequiresSilverlight=true)]
        //public void Gauge_CodedStep2()
        //{
            //// Verify 'ControlNameTextblock' text Same 'Gauge'
            //Assert.IsFalse((ArtOfTest.Common.CompareUtils.StringCompare(Pages.TelerikGaugeForSilverlight0.SilverlightApp.ControlNameTextblock.Text, "Gauge", ArtOfTest.Common.StringCompareType.Same) == false), string.Format("Verify \'ControlNameTextblock\' text Same \'Gauge\' failed.  Actual value \'{0}\'", Pages.TelerikGaugeForSilverlight0.SilverlightApp.ControlNameTextblock.Text));
            
        //}
    
        [CodedStep(@"Wait for 'TextBlockTextblock' text Same 'EXPLORE ALL CONTROLS'", RequiresSilverlight=true)]
        public void _08Gauge_CodedStep()
        {
            // Wait for 'TextBlockTextblock' text Same 'EXPLORE ALL CONTROLS'
            Wait.For<ArtOfTest.WebAii.Silverlight.UI.TextBlock>((a_) => ArtOfTest.Common.CompareUtils.StringCompare(a_.Text, "EXPLORE ALL CONTROLS", ArtOfTest.Common.StringCompareType.Same), Pages.SilverlightControls.SilverlightApp.TextBlockTextblock, false, 30000);
            
        }
    
        [CodedStep(@"Click AllControlsButton", RequiresSilverlight=true)]
        public void _08Gauge_CodedStep1()
        {
            // Click AllControlsButton
            ActiveBrowser.Window.Maximize();
            Pages.SilverlightControls.SilverlightApp.AllControlsButton.User.Click(ArtOfTest.WebAii.Core.MouseClickType.LeftClick, 92, 19, ArtOfTest.Common.OffsetReference.TopLeftCorner, ArtOfTest.Common.ActionPointUnitType.Pixel);
            
        }
    
        [CodedStep(@"Verify 'JUN152013Textblock' text Same 'JUN 15, 2013' - DataDriven: [$(DateOnPage)]", RequiresSilverlight=true)]
        public void _08Gauge_CodedStep2()
        {
            // Verify current computer date is same as the date on the page
            string computerDate = DateTime.Now.ToString( "MMM dd, yyyy").ToUpper();
            Assert.IsFalse((ArtOfTest.Common.CompareUtils.StringCompare(computerDate, ((string)(System.Convert.ChangeType(Data["DateOnPage"], typeof(string)))), ArtOfTest.Common.StringCompareType.Same) == false), string.Format("Verify current date"+computerDate + "failed.  Actual value \'{0}\'", (string)(System.Convert.ChangeType(Data["DateOnPage"], typeof(string)))));
            
        }
    }
}
