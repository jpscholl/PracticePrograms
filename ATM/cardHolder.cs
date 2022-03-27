namespace ATM
{
    public class cardHolder
    {
        public String cardNum;
        public int pin;
        public String firstName;
        public String lastName;
        public double balance;

        public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        //get functions
        public string getNum()
        {
            return cardNum;
        }

        public int getPin()
        {
            return pin;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public double getBalance()
        {
            return balance;
        }
        //set functions
        public void setNum(String newCardNum)
        {
            cardNum = newCardNum;
        }
        public void setPin(int newPin)
        {
            pin = newPin;
        }
        public void setFirstName(String newFirstName)
        {
            firstName = newFirstName;
        }
        public void setLastName(String newLastName)
        {
            lastName = newLastName;
        }
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }
    }
}
