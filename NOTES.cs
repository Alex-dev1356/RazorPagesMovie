using Humanizer;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using RazorPagesMovie.Models;
using System.Numerics;
using System.Threading;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static NuGet.Packaging.PackagingConstants;

namespace RazorPagesMovie
{
    public class NOTES
    {
        //To Scaffold the movie model, here is the steps to follow and it is way easier:
        #region
        //Create the Pages/Movies folder:

        //Right-click on the Pages folder > Add > New Folder.
        //Name the folder Movies.
        //Right-click on the Pages/Movies folder > Add > New Scaffolded Item.

        //New Scaffolded Item

        //In the Add New Scaffold dialog, select Razor Pages using Entity Framework(CRUD) > Add.

        //Add Scaffold

        //Complete the Add Razor Pages using Entity Framework(CRUD) dialog:

        //In the Model class drop down, select Movie(RazorPagesMovie.Models).
        //In the Data context class row, select the + (plus) sign.
        //In the Add Data Context dialog, the class name RazorPagesMovie.Data.RazorPagesMovieContext is generated.
        //In the Database provider drop down, select SQL Server.
        //Select Add.
        //Add Razor Pages

        //The appsettings.json file is updated with the connection string used to connect to a local database.

        //After creating the Scaffolding go to Tools > Nuget Package Manager > Package Manager Console
        //Then type in the command 'Add-Migration {Migration Name}' ex. Add-Migration InitialCreate
        //Then we need to update the DB so type in 'Update-Database'
        #endregion
    }
}
