<%@ Page Title="" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeBehind="PasswordRecovery.aspx.cs" Inherits="Team_Project.Public.PasswordRecovery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
        <MailDefinition From="me@me.com" Subject="암호 찾기 결과 전송">
        </MailDefinition>
    </asp:PasswordRecovery>
</asp:Content>
