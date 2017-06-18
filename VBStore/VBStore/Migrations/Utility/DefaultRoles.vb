Partial Class AppConstants

	''' <summary>
	''' Defines the default roles that will be created automatically
	''' </summary>
	''' <returns></returns>
	Shared ReadOnly Property DefaultRoles As String() = {"Admin", "User"} ' Admin=Can do anything.  User=regular user that registers on site.
    Public Const DefaultRole As String = "User"
End Class
