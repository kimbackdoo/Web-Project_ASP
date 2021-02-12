<%@ Page Title="" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeBehind="Read.aspx.cs" Inherits="Team_Project.Board.Read" %>

<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" Runat="Server">
    <table class="tbl01" cellpadding="0" cellspacing="0">
        <tr><td width="5px"></td><td class="td01"></td></tr>
        <tr><td></td><td class="td03">
            <img src="/WebEx/13/images/title_icon.gif" />
            &nbsp;&nbsp;&nbsp;글 읽 기</td></tr>
        <tr><td></td><td class="td01"></td></tr>
        <tr><td></td><td height="15"></td></tr>
    </table>
    <table class="tbl01" cellpadding="0" cellspacing="0">
            <tr><td width="5px"></td><td>
            <table class="tbl01" cellpadding="0" cellspacing="0">
                <tr><td colspan="2" class="td02"></td></tr>
                <tr><td class="td05">· 작성자</td>
                    <td>
                        <asp:Label ID="lblWriter" runat="server" Text="Label"></asp:Label>
                    </td></tr>
                <tr><td colspan="2" class="td08"></td></tr>
                <tr><td class="td04">· 작성 날짜</td>
                    <td>
                        <asp:Label ID="lblRegDate" runat="server" Text="Label"></asp:Label>
                    </td></tr>
                <tr><td colspan="2" class="td08"></td></tr>
                <tr><td class="td04">· 제목</td>
                    <td>
                        <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                    </td></tr>
                <tr><td colspan="2" class="td08"></td></tr>
                <tr>
                    <td style="padding-left:20px; padding-top:7px" valign="top">· 내용</td>
                    <td class="p02">
                        <asp:TextBox  ID="txtMessage" CssClass="p01"
                            runat="server" Text="Label" Width="400px" 
                            Height="200px" BorderStyle="Solid" BorderColor="#B0ADF5" 
                            BorderWidth="1px" ReadOnly="True" TextMode="MultiLine">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr><td colspan="2" class="td02"></td></tr>
            </table>
    </td></tr></table>
    <table class="tbl01" cellpadding="0" cellspacing="0">
        <tr><td width="5px" height="15px"></td><td colspan="5"></td></tr>
        <tr><td></td><td class="td06"></td>
            <td align="left" width="60px">
                <asp:ImageButton ID="btnEdit" runat="server"  
                    ImageUrl="~/images/btn_edit.gif"/>
            </td><td align="left" width="60px">
                <asp:ImageButton ID="btnReply" runat="server"  
                    ImageUrl="~/images/btn_reply.gif" />
            </td><td align="left" width="60px">
                <asp:ImageButton ID="btnDelete" runat="server"  
                    ImageUrl="~/images/btn_delete.gif" />
            </td>
            <td align="right">
                <asp:ImageButton ID="btnList" runat="server"
                    ImageUrl="~/images/btn_list.gif"
                    PostBackUrl="~/Board/List.aspx" CausesValidation="False" />
            </td></tr>
        <tr><td height="10px"></td><td colspan="5"></td></tr>
    </table>
</asp:Content>