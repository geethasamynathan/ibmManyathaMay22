using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace StateManagementDemo
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["Title"] = " Server-Side State Management -Application State";
            Application["ExecutionCount"] = 0;
            Application["UserCount"] = 0;
        }
        void Application_BeginRequest(object sender, EventArgs e)
        {
            Application.Lock();
            Application["ExecutionCount"] = Convert.ToInt32(Application["ExecutionCount"].ToString()) + 1;
            Application.UnLock();
        }
        void Application_End()
        {
            Response.Write("Thanks for Visiting our Site.");
        }

        void Session_Start()
        {
            Application.Lock();
            Application["UserCount"] = Convert.ToInt32(Application["UserCount"].ToString()) + 1;
            Application.UnLock();
        }

        void Session_End()
        {
            Session.Clear();
        }
            
    }
}