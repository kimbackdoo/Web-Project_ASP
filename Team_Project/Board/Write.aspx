<%@ Page Title="" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeBehind="Write.aspx.cs" Inherits="Team_Project.Board.Write" %>

<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" Runat="Server">
    <table class="tbl01" cellpadding="0" cellspacing="0">
        <tr><td width="5px"></td><td class="td01"></td></tr>
        <tr><td></td><td class="td03">
            <img src="/images/title_icon.gif" />
            &nbsp;&nbsp;&nbsp;글 쓰 기</td></tr>
        <tr><td></td><td class="td01"></td></tr>
        <tr><td></td><td height="15"></td></tr>
    </table>
    <table class="tbl01" cellpadding="0" cellspacing="0">
            <tr><td width="5px"></td><td>
            <table class="tbl01" cellpadding="0" cellspacing="0">
                <tr><td colspan="2" class="td02"></td></tr>
                <tr><td class="td05">·&nbsp;&nbsp;&nbsp;작성자</td>
                    <td>
                        <asp:TextBox ID="txtWriter" runat="server" MaxLength="50" 
                            CssClass="p03"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvWriter" runat="server" 
                            ErrorMessage="작성자는 필수 입력 항목입니다." Display="None"
                            ControlToValidate="txtWriter">
                        </asp:RequiredFieldValidator>
                    </td></tr>
                <tr><td colspan="2" class="td08"></td></tr>
                <tr><td class="td04">·&nbsp;&nbsp;&nbsp;글 비밀번호</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" 
                            TextMode="Password" MaxLength="50" CssClass="p03">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                            ErrorMessage="글 비밀번호는 필수 입력 항목입니다."
                            ControlToValidate="txtPassword" Display="None">
                        </asp:RequiredFieldValidator>
                    </td></tr>
                <tr><td colspan="2" class="td08"></td></tr>
                <tr><td class="td04">·&nbsp;&nbsp;&nbsp;제목</td>
                    <td>
                        <asp:TextBox ID="txtTitle" runat="server" MaxLength="250"
                            Width="400px" CssClass="p03"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                            ErrorMessage="제목은 필수 입력 항목입니다."
                            ControlToValidate="txtTitle" Display="None">
                        </asp:RequiredFieldValidator>
                    </td></tr>
                <tr><td colspan="2" class="td08"></td></tr>
                <tr>
                    <td class="td07">·&nbsp;&nbsp;&nbsp;내용</td>
                    <td class="p02">
                        <asp:TextBox ID="txtMessage" runat="server" Height="200px"
                            TextMode="MultiLine" Width="400px" CssClass="p01"></asp:TextBox>
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
                <asp:ImageButton ID="btnWrite" runat="server" onclick="btnWrite_Click" 
                    ImageUrl="~/images/btn_write.gif"/>
            </td>
            <td align="right">
                <asp:ImageButton ID="btnList" runat="server"
                    ImageUrl="~/images/btn_list.gif"
                    PostBackUrl="~/Board/List.aspx" CausesValidation="False" />
            </td></tr>
        <tr><td height="10px"></td><td colspan="3"></td></tr>
    </table>
</asp:Content>