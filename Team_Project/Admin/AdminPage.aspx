<%@ Page Title="" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Team_Project.Admin.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" runat="server">
    <asp:SqlDataSource ID="dsrcMember" runat="server" ConnectionString="<%$ ConnectionStrings:CS_aspnet %>" SelectCommand="SELECT [PasswordQuestion], [UserName], [UserId],[Email] FROM [vw_aspnet_MembershipUsers]"></asp:SqlDataSource>
    <asp:DataList ID="dlstMember" runat="server" CellPadding="4" ForeColor="#333333" Width="417px" OnItemCommand="dlstMember_ItemCommand" OnDeleteCommand="dlstMember_DeleteCommand" OnCancelCommand="dlstMember_CancelCommand" OnEditCommand="dlstMember_EditCommand" OnUpdateCommand="dlstMember_UpdateCommand">
        <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
        
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />        
        <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <HeaderTemplate><h3>회원 정보</h3></HeaderTemplate>
        <ItemTemplate> 
            <asp:LinkButton ID="lbtnMemInfo" runat="server" CommandName="Select" Text='<%#Eval("UserName")%>' />
            
            
        </ItemTemplate>
        <SelectedItemTemplate>
            아이디 : <asp:Label ID="lblUsername" runat="server" Text='<%# Eval("UserName") %>' />
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lbtnDelete" runat="server" Text="수정" CommandName="Edit"/>
            <br />
            이메일 : <asp:Label ID="lblEmail" runat="server" Text='<%# Eval("Email")%>' />
            <br />
            보안 질문 : <asp:Label ID="lblPasswordQuestion" runat="server" Text='<%# Eval("PasswordQuestion") %>' />
            <br />
        </SelectedItemTemplate>
        <EditItemTemplate>
            <asp:Label ID="lblUserId" runat="server" Text='<%#Eval("UserId") %>' Visible="false"/>
            <asp:Label ID="lblUserName" runat="server" Text='<%#Eval("UserName") %>'/>&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete">[삭제]</asp:LinkButton><br />
            <asp:TextBox ID="tbEamil" runat="server" Text='<%#Eval("Email") %>'/>
            <br />
            <asp:LinkButton ID="lbtnUpdate" runat="server" CommandName="Update">[확인]</asp:LinkButton>
            <asp:LinkButton ID="lbtnCancel" runat="server" CommandName="Cancel">[취소]</asp:LinkButton>
        </EditItemTemplate>
    </asp:DataList>
</asp:Content>
