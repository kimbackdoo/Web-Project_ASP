<%@ Page Title="" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeBehind="CheckPassword.aspx.cs" Inherits="Team_Project.Board.CheckPassword" %>

<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" Runat="Server">
    <table class="tbl01" cellpadding="0" cellspacing="0">
        <tr><td width="5px"></td><td class="td01"></td></tr>
        <tr><td></td><td class="td03">
            <img src="/images/title_icon.gif" />
            &nbsp;&nbsp;&nbsp;비밀번호 확인</td></tr>
        <tr><td></td><td class="td01"></td></tr>
        <tr><td></td><td height="15"></td></tr>
        <tr><td></td><td class="td04">
            ※ 글을 작성했을 때 입력한 비밀번호를 입력하세요.
        </td></tr>
        <tr><td></td><td height="15"></td></tr>
    </table>
    <table class="tbl01" cellpadding="0" cellspacing="0">
            <tr><td width="5px"></td><td>
            <table class="tbl01" cellpadding="0" cellspacing="0">
                <tr><td colspan="2" height="2"></td></tr>
                <tr><td style="padding-left:20px; height:30px; width:100px">
                        · 글 비밀번호</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" 
                            TextMode="Password" MaxLength="50">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                            ErrorMessage="비밀번호를 넣어 확인해야 합니다."
                            ControlToValidate="txtPassword" Display="None"></asp:RequiredFieldValidator>
                    </td></tr>
                <tr><td></td><td>
                    <asp:ValidationSummary ID="vsWrite" runat="server"
                        ShowMessageBox="True" ShowSummary="False" />
                    <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
                </td></tr>
            </table>
    </td></tr></table>
    <table class="tbl01" cellpadding="0" cellspacing="0">
        <tr><td width="5px" height="15px"></td><td colspan="3"></td></tr>
        <tr><td></td><td class="td06"></td><td align="left">
                <asp:ImageButton ID="btnEditOrDelete" runat="server" 
                    onclick="btnEditOrDelete_Click" />
            </td>
            <td align="right">
                <asp:ImageButton ID="btnList" runat="server"
                    ImageUrl="~/images/btn_list.gif"
                    PostBackUrl="~/Board/List.aspx" CausesValidation="False" />
            </td></tr>
        <tr><td height="10px"></td><td colspan="3"></td></tr>
    </table>
</asp:Content>
