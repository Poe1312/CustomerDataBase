public class Customer
{
public string name;
public int id;
public double balance;

public Customer (string nameValue, int idValue, double balanceValue) {
    name = nameValue;
    id = idValue;
    balance = balanceValue;
}

public Customer (string nameValue, int idValue) {
    name = nameValue;
    id = idValue;
    balance = 0;
}

public void Deposit (double amount) {
    balance += amount;
}

public void Withdraw (double amount) {
    balance -= (balance > amount ? amount : 0);
   // Console.WriteLine(balance + " " + amount);
}


public double GetBalance (){
    return balance;
}
class CustomerDatabase //1
{
    Customer[] customers; //2

public CustomerDatabase () { //3
    customers = new Customer[10];
}

public bool Add (Customer customer) { //4.1
for (int i = 0; i < customers.Length; i++) {
    if (customers[i] == null) {
    customers[i] = customer;
    return true; 
}
    }
    return false;
}

public void Remove (int id) { //4.2
for (int i = 0; i < customers.Length; i++) {
    if (customers[i] != null && customers[i].id == id) {
    customers[i] = null;
        }
    }
}
public Customer[] Get () { //4.3
    return (Customer[])customers.Clone();
}

public void Print(){ //4.4 //Clueless 
    foreach (Customer c in customers) {
    if (c==null) continue;
    Console.WriteLine(c.name);
    }
}
//5
public static void Main (){ 
CustomerDatabase db = new CustomerDatabase(); //Why db???

Console.WriteLine("Result:" + db.Add(new Customer("Parsa Eshtelaq", 2003)));
Console.WriteLine("Result:" + db.Add(new Customer("Caspian Eshtelaq", 2009)));
Console.WriteLine("Result:" + db.Add(new Customer("Kaitlyn Oswald", 2004)));
Console.WriteLine("Result:" + db.Add(new Customer("Darioush Eshtelaq", 1971)));
Console.WriteLine("Result:" + db.Add(new Customer("Peymaneh Abadi", 1972)));
Console.WriteLine();
db.Print();
        }
    }
}