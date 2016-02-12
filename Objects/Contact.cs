using System.Collection.Generic;

namespace Contacts.Objects
{
  public class Contacts{
    private string _name;
    private int _phonenumber;
    private string _address;
    private int _id;
    private static List<Contact> _contactList = new List<Contact> {};

    public Contact(string name, int phonenumber, string address)
    {
      _name = name;
      _phonenumber = phonenumber;
      _address = address;
      _contactList.Add(this);
      _id = _contactList.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetNumber()
    {
      return _phonenumber;
    }
    public int SetNumber(int newNumber)
    {
      _phonenumber = newNumber;
    }
    public string GetAddress()
    {
      return _address;
    }
    public string SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _contactList;
    }
    public static void ClearAll()
    {
      _contactList.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _contactList[searchId-1];
    }
  }
}
