﻿using Shoe.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoe.DAO
{
    public interface ICartItemDAO
    {
        public CartItem addCartItem(int userID, int productID, int quantity);
        public CartItem updateQuantity(CartItem item);
        public bool deleteCartItem(int cartItemID);
        public CartItem GetCartItem(int userID, int productID);
        public List<CartItem> getListCartItem(int userUD);
        public void deleteCartItemUser(int userID);
    }
}
