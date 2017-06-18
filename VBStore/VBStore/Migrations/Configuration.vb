Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports System
Imports System.Data.Entity.Migrations
Imports System.Linq

Namespace Migrations

    NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of ApplicationDbContext)

        Sub New()
            AutomaticMigrationsEnabled = False
        End Sub

        Protected Overrides Sub Seed(context As ApplicationDbContext)
            '  This method will be called after migrating to the latest version.

            '  You can use the DbSet(Of T).AddOrUpdate() helper extension method
            '  to avoid creating duplicate seed data. E.g.
            '
            '    context.People.AddOrUpdate(
            '       Function(c) c.FullName,
            '       New Customer() With {.FullName = "Andrew Peters"},
            '       New Customer() With {.FullName = "Brice Lambson"},
            '       New Customer() With {.FullName = "Rowan Miller"})
            Dim store As New RoleStore(Of IdentityRole)(context)
            Dim manager As New RoleManager(Of IdentityRole)(store)

            For Each role In AppConstants.DefaultRoles.Where(Function(r) Not manager.RoleExists(r))
                manager.Create(New IdentityRole(role))
            Next


        End Sub

    End Class

End Namespace
