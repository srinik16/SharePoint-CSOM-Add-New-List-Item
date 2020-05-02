using System;  
using Microsoft.SharePoint.Client;  

namespace TestApplication
{  
  class TestAddNewItem  
  {  
     static void Main()  
     {     
        ClientContext clientContext = new ClientContext("http://spsite/sites/sitecollname");  
        
        List oList = clientContext.Web.Lists.GetByTitle("TestList");  
            
        ListItemCreationInformation itemCreateInfo = new ListItemCreationInformation();  
            
        ListItem oListItem = oList.AddItem(itemCreateInfo);  
            
        oListItem["Title"] = "TestItem123";
            
        oListItem.Update();  
        
        clientContext.ExecuteQuery();
      }  
   }  
}  