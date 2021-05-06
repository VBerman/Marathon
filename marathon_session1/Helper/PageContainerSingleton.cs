using marathon_session1.PageApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace marathon_session1.Helper
{
    class PageContainerSingleton
    {
        private static PageContainer instanse;

        public static PageContainer Instanse
        {
            get
            {
                instanse = instanse ?? new PageContainer();
                return instanse;
                
            
            }
            set { instanse = value; }
        }

        public static void NavigatePage(Page navigatePage, bool IsHasLogout)
        {
            Instanse.IsVisibleLogout = IsHasLogout;
            Instanse.FrameContainer.Navigate(navigatePage);
        }
    }
}
