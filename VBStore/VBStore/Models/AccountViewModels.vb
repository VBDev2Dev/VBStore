Imports System.ComponentModel.DataAnnotations

Public Class ExternalLoginConfirmationViewModel
    <Required>
    <Display(Name:=NameOf(Email))>
    Property Email As String
End Class

Public Class ExternalLoginListViewModel
    Property ReturnUrl As String
End Class

Public Class SendCodeViewModel
    Property SelectedProvider As String
    Property Providers As ICollection(Of SelectListItem)
    Property ReturnUrl As String
    Property RememberMe As Boolean
End Class

Public Class VerifyCodeViewModel
    <Required>
    Property Provider As String

    <Required>
    <Display(Name:=NameOf(Code))>
    Property Code As String

    Property ReturnUrl As String

    <Display(Name:="Remember this browser?")>
    Property RememberBrowser As Boolean

    Property RememberMe As Boolean
End Class

Public Class ForgotViewModel
    <Required>
    <Display(Name:=NameOf(Email))>
    Property Email As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:=NameOf(Email))>
    <EmailAddress>
    Property Email As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:=NameOf(Password))>
    Property Password As String

    <Display(Name:="Remember me?")>
    Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required>
    <EmailAddress>
    <Display(Name:=NameOf(Email))>
    Property Email As String

    <Required>
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:=NameOf(Password))>
    Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirm password")>
    <Compare(NameOf(Password), ErrorMessage:="The password and confirmation password do not match.")>
    Property ConfirmPassword As String
End Class

Public Class ResetPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:=NameOf(Email))>
    Property Email() As String

    <Required>
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:=NameOf(Password))>
    Property Password() As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirm password")>
    <Compare(NameOf(Password), ErrorMessage:="The password and confirmation password do not match.")>
    Property ConfirmPassword() As String

    Property Code() As String
End Class

Public Class ForgotPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:=NameOf(Email))>
    Property Email() As String
End Class
