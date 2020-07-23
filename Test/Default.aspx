<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Test._Default" Async="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Search Query Manager</h1>
        <p class="lead">Enter search term: </p>
        <input type="text" placeholder="Enter here... " name="SearchTermTxt" runat="server" id="SearchText">
        </>    
        <p>
            <asp:Button name="BtnSearch" ID="btnSearch" class="btn btn-primary btn-lg" runat="server" Text="Search" OnClick="btnSearch_ClickAsync" /></p>
    </div>
    <div>
        <asp:Repeater ID="rptResultTable" runat="server">
            <HeaderTemplate>
                <table class="table">
                    <tr>
                        <th scope="col" >Search Engine  
                                </th>  
                                <th scope="col" >Result Title
                                </th>  
                                <th scope="col" >Time  
                                </th>  
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td width="15%"><%# Eval("SearchEngine") %></td>
                    <td width="65%"><%# Eval("Title") %></td>
                    <td width="*"><%# Eval("EnteredDate") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
