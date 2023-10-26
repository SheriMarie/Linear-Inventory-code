using UnityEngine;

public static class ItemData //static exists within one part of memory 
{
    //Create Item
    public static Item CreateItem(int itemId)
    {
        //reference values 
        string name = "";
        string description = "";
        string icon = "";
        string mesh = "";
        int value = 0;
        int amount = 0;
        ItemType type = ItemType.Food;
        int damage = 0;
        int armour = 0;
        int heal = 0;

        //switch statement of items 
        switch (itemId)
        {
            #region Ingredient 0-99
            case 0:
            name = "Acorn";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Ingredient;
                icon = "Ingredient/Acorn";
                mesh = "Ingredient/Acorn";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            case 1:
                name = "BarbedTendril";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Ingredient;
                icon = "Ingredient/BarbedTendril";
                mesh = "Ingredient/BarbedTendril";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            case 2:
                name = "WHMroom";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Ingredient;
                icon = "Ingredient/WHMroom";
                mesh = "Ingredient/WHMroom";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            #endregion
            #region Potion 100-199
            case 100:
                name = "SmallStamina";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Potion;
                icon = "Potion/SmallStamina";
                mesh = "Potion/SmallStamina";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            case 101:
                name = "MediumMana";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Potion;
                icon = "Potion/MediumMana";
                mesh = "Potion/MediumMana";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            case 102:
                name = "MediumHealth";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Potion;
                icon = "Potion/MediumHealth";
                mesh = "Potion/MediumHealth";
                damage = 0;
                armour = 0;
                heal = 0;
                break;

            #endregion
            #region Scroll 200-299
            case 200:
                name = "RedScroll";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Scroll;
                icon = "Scroll/RedScroll";
                mesh = "Scroll/RedScroll";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            case 201:
                name = "BrownScroll";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Scroll;
                icon = "Scroll/BrownScroll";
                mesh = "Scroll/BrownScroll";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            case 202:
                name = "BlueScroll";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Scroll;
                icon = "Scroll/BlueScroll";
                mesh = "Scroll/BlueScroll";
                damage = 0;
                armour = 0;
                heal = 0;
                break;

            #endregion
            #region Food 300-399
            case 300:
                name = "Apple";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Food;
                icon = "Food/Apple";
                mesh = "Food/Apple";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            #endregion
            #region Armour 400-499
            case 400:
                name = "WornShirt";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Armour;
                icon = "Armour/WornShirt";
                mesh = "Armour/WornShirt";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            case 401:
                name = "IronHelm";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Armour;
                icon = "Armour/IronHelm";
                mesh = "Armour/IronHelm";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            case 402:
                name = "FurBraces";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Armour;
                icon = "Armour/FurBraces";
                mesh = "Armour/FurBraces";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            #endregion
            #region Weapon 500-599
            case 500:
                name = "Sword";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Weapon;
                icon = "Weapon/Sword";
                mesh = "Weapon/Sword";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            case 501:
                name = "Bow";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Weapon;
                icon = "Weapon/Bow";
                mesh = "Weapon/Bow";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            case 502:
                name = "Axe";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Weapon;
                icon = "Weapon/Axe";
                mesh = "Weapon/Axe";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            #endregion
            #region Craftable 600-699
            case 600:
                name = "Bag";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Craftable;
                icon = "Craftable/Bag";
                mesh = "Craftable/Bag";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            #endregion
            #region Money 700-799
            case 700:
                name = "Coins";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Money;
                icon = "Money/Coins";
                mesh = "Money/Coins";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            #endregion
            #region Quest 800-899
            case 800:
                name = "Gem";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Quest;
                icon = "Quest/Gem";
                mesh = "Quest/Gem";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            #endregion
            #region Misc 900-999
            case 900:
                name = "Book";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Misc;
                icon = "Misc/Book";
                mesh = "Misc/Book";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
            #endregion

            default:
                itemId = 0;
                name = "Acorn";
                description = "";
                amount = 1;
                value = 1;
                type = ItemType.Ingredient;
                icon = "Ingredient/Acorn";
                mesh = "Ingredient/Acorn";
                damage = 0;
                armour = 0;
                heal = 0;
                break;
        }

        //Send Item Data to item
        Item tempItemData = new Item
        {
            ID = itemId,
            Name = name,
            Description = description,
            Amount = amount,
            Type = type,
            Damage = damage,
            Armour = armour,
            Heal = heal,
            Icon = Resources.Load("Icons/"+icon)as Texture2D,
            ItemMesh = Resources.Load("Mesh/"+mesh)as GameObject
        };
        return tempItemData;
    }
}
