using Nancy;
using System.Collections.Generic;
using Contacts.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      };
      Get["/contacts/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contact_added"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-number"], Request.Form["new-address"]);
        newContact.AddContact();
        return View["contact_added.cshtml", newContact];
      };
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts]
      };
      Get["contacts/{id}"] = parameters => {
        Contact contact = Contact.Find(parameters.id);
        return View["contact.cshtml", contact];
      };
      Post["/contacts_cleared"] = _ => {
        Contact.ClearAll();
        return View["contacts_cleared.cshtml"];
      };
    }
  }
}
