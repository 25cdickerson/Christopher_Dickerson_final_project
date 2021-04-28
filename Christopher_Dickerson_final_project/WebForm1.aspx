<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Christopher_Dickerson_final_project.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet2.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <br /><br /><br /><br /><br /><br />
        <div id="form">
            <asp:Label ID="LName" runat="server" Text="Your Name: " CssClass="Label" />
            <asp:TextBox ID="TName" runat="server" Text="" CssClass="Text" />
            <asp:RequiredFieldValidator ID="validName" runat="server" 
                ErrorMessage="Enter Name" Forecolor="Red" 
                ControlToValidate="TName" Type="String" Font-Bold="true" ><span>*</span></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="LEmail" runat="server" Text="Your Email: " CssClass="Label" />
            <asp:TextBox ID="TEmail" runat="server" Text="" CssClass="Text" />
            <asp:RequiredFieldValidator ID="validEmailRF" runat="server" 
                ErrorMessage="Enter Email" Forecolor="Red" 
                ControlToValidate="TEmail" Type="String" Font-Bold="true" Display="Dynamic" ><span>*</span></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="validEmailRE" runat="server"
                ErrorMessage="Incorrect Email" Forecolor="Red" Font-Bold="true" 
                ControlToValidate="TEmail" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                <span>*</span></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="LWebsite" runat="server" Text="Website: " CssClass="Label" />
            <asp:TextBox ID="TWebsite" runat="server" Text="" CssClass="Text" />
            <br />
            <asp:Label ID="LSubject" runat="server" Text="Subject: " CssClass="Label" />
            <asp:TextBox ID="TSubject" runat="server" Text="" CssClass="Text" />
            <asp:RequiredFieldValidator ID="validSubject" runat="server" 
                ErrorMessage="Enter Subject" Forecolor="Red" 
                ControlToValidate="TSubject" Type="String" Font-Bold="true" Display="Dynamic" ><span>*</span></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="LMessage" runat="server" Text="Message: " CssClass="Label" />
            <asp:TextBox ID="TMessage" runat="server" Text="" CssClass="Text" />
            <asp:RequiredFieldValidator ID="validMessage" runat="server" 
                ErrorMessage="Enter Subject" Forecolor="Red" 
                ControlToValidate="TSubject" Type="String" Font-Bold="true" Display="Dynamic" ><span>*</span></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="LMath" runat="server" Text="To prevent automated spam, please answer this question: 10+5=" CssClass="Label" />
            <br />
            <asp:TextBox ID="TMath" runat="server" CssClass="Text" />
            <asp:RequiredFieldValidator ID="validMath" runat="server"
                ErrorMessage="Enter Math" ForeColor="Red"
                ControlToValidate="TMath" Type="String" Font-Bold="true" Display="Dynamic" ><span>*</span></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="BSubmit" runat="server" Text="Submit" CssClass="Button" OnClick="BSubmit_Click" />
            <asp:Button ID="BClear" runat="server" Text="Clear" CssClass="Button" />
            <br />
            <asp:Label ID="LInfo" runat="server" Visible="false" CssClass="Label" />
            <asp:ValidationSummary ID="validSummary" runat="server" ForeColor="Red" />
        </div>
</asp:Content>
