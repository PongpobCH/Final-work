class user{

    
    private string Email;
    private string Password;

    private bool HaveAccount;

    private bool guest;
    
    

    public user ( string Email, string Password, bool HaveAccount, bool guest){

        
        this.Email = Email;
        this.Password = Password;
        this.HaveAccount = HaveAccount;
        this.guest = guest;

    }
   




    
    public string GetEmail(){
        return this.Email;
    }
    public string GetPassword(){
        return this.Password;
    }
    public bool GetHaveAccount(){
        return this.HaveAccount;
    }
    public bool GetGuest(){
        return this.guest;
    }
    
}
    
    
    
    
    




