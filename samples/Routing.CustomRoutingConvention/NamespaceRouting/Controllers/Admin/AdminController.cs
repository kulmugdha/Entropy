using Microsoft.AspNet.Mvc;
using NamespaceRouting.Models;

namespace MySite.Admin
{
    /// <summary>
    /// Summary description for AdminController
    /// </summary>
    public class AdminController : Controller
    {
	    public string AddUser(string userName)
        {
            return string.Format("User {0} added successfully", userName);
        }
    }
}