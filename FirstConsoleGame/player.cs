namespace FirstConsoleGame;

class Player
{
    public int hp;
    public bool hasWeapon;
    public int dmg;

    public Player(int hp = 10, bool hasWeapon = false, int dmg = 1)
    {
        this.hp = hp;
        this.hasWeapon = hasWeapon;
        this.dmg = dmg;
        CheckWeapon();
    }

    public void CheckWeapon()
    {
        if (hasWeapon)
        {
            dmg += 2;
        }
    }

    public bool CheckBoolWeapon()
    {
        if (hasWeapon)
        {
            return true;
        }

        return false;
    }
}