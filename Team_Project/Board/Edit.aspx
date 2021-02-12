<%@ Page Title="" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Team_Project.Board.Edit" %>

<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" Runat="Server">
    <table class="tbl01" cellpadding="0" cellspacing="0">
        <tr><td width="5px"></td><td class="td01"></td></tr>
        <tr><td></td><td class="td03">
            <img src="/images/title_icon.gif" />
            &nbsp;&nbsp;&nbsp;글 수 정</td></tr>
        <tr><td></td><td class="td01"></td></tr>
        <tr><td></td><td height="15"></td></tr>
    </table>
    <table class="tbl01" cellpadding="0" cellspacing="0">
            <tr><td width="5px"></td><td>
            <table class="tbl01" cellpadding="0" cellspacing="0">
                <tr><td colspan="2" class="td02"></td></tr>
                <tr><td class="td05">· 작성자</td>
                    <td>
                        <asp:TextBox ID="txtWriter" runat="server" MaxLength="50">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvWriter" runat="server" 
                            ErrorMessage="작성자는 필수 입력 항목입니다." Display="None"
                            ControlToValidate="txtWriter">
                        </asp:RequiredFieldValidator>
                    </td></tr>
                <tr><td colspan="2" class="td08"></td></tr>
                <tr><td class="td04">· 제목</td>
                    <td>
                        <asp:TextBox ID="txtTitle" runat="server" TextMode="SingleLine" 
                            MaxLength="250" Width="400px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                            ErrorMessage="제목은 필수 입력 항목입니다."
                            ControlToValidate="txtTitle" Display="None">
                        </asp:RequiredFieldValidator>
                    </td></tr>
                <tr><td colspan="2" class="td08"></td></tr>
                <tr>
                    <td style="padding-left:20px; padding-top:7px" valign="top">· 내용</td>
                    <td class="p02">
                        <asp:TextBox ID="txtMessage" runat="server" Height="200px" 
                            CssClass="p01" TextMode="MultiLine" Width="400px">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr><td colspan="2" class="td02">
                    <asp:ValidationSummary ID="vsWrite" runat="server"
                        ShowMessageBox="True" ShowSummary="False" />
                </td></tr>
            </table>
    </td></tr></table>
    <table class="tbl01" cellpadding="0" cellspacing="0">
        <tr><td width="5px" height="15px"></td><td colspan="3"></td></tr>
        <tr><td></td><td class="td06"></td><td align="left">
                <asp:ImageButton ID="btnEdit" runat="server"
                    ImageUrl="~/images/btn_edit.gif" onclick="btnEdit_Click"/>
            </td>
            <td align="right">
                <asp:ImageButton ID="btnList" runat="server"
                    ImageUrl="~/images/btn_list.gif"
                    PostBackUrl="~/Board/List.aspx" CausesValidation="False" />
            </td></tr>
        <tr><td height="10px"></td><td colspan="3"></td></tr>
    </table>
</asp:Content>
