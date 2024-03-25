<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div class="container" style="margin:4px;">
       <div class="row" style="margin-top:4px;">
           <div class="col-md-1">Име</div>
           <div class="col-md-2">
               <asp:TextBox ID="txtbox_ime" runat="server"></asp:TextBox></div>
           <div class="col-md-3">
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Внесете име" ControlToValidate="txtbox_ime" ForeColor="Red"></asp:RequiredFieldValidator>
           </div>
       </div>
       <div class="row" style="margin-top:4px;">
           <div class="col-md-1">Лозинка</div>
           <div class="col-md-2">
               <asp:TextBox ID="txtbox_loz" runat="server"></asp:TextBox></div>
           <div class="col-md-3">
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Внесете лозинка" ControlToValidate="txtbox_loz" ForeColor="Red"></asp:RequiredFieldValidator>
           </div>
          </div>
       <div class="row" style="margin-top:4px;">
           <div class="col-md-1">е-адреса</div>
           <div class="col-md-2">
               <asp:TextBox ID="txtbox_email" runat="server"></asp:TextBox></div>
           <div class="col-md-3">
               <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Невалиден формат" ControlToValidate="txtbox_email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
               </div>
       </div>
        <div class="row" style="margin-top:4px;">
           <div class="col-md-1 m-4"></div>
           <div class="col-md-2 m-4">
               <asp:Button ID="btn_najava" runat="server" Text="Најавете се" OnClick="btn_najava_Click" /></div>
       </div>

   </div>

    
</asp:Content>
