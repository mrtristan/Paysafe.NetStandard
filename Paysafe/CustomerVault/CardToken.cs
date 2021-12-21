/*
 * Copyright (c) 2014 Optimal Payments
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
 * associated documentation files (the "Software"), to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, publish, distribute,
 * sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
 * NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.CustomerVault
{
    public class CardToken : Paysafe.Common.JSONObject
    {
        /// <summary>
        /// Initialize the Card object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public CardToken(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {CustomerVaultConstants.id, STRING_TYPE},
            {CustomerVaultConstants.paymentToken, STRING_TYPE},
            {CustomerVaultConstants.timeToLiveSeconds, INT_TYPE},
            {CustomerVaultConstants.card, typeof(Card)},
            {CustomerVaultConstants.billingAddress, typeof(BillingAddress)}
            
        };

        /// <summary>
        /// Get the id
        /// </summary>
        /// <returns>String</returns>
        public String id()
        {
            return this.getProperty(CustomerVaultConstants.id);
        }

        /// <summary>
        /// Set the id
        /// </summary>
        /// <returns>void</returns>
        public void id(String data)
        {
            this.setProperty(CustomerVaultConstants.id, data);
        }

        /// <summary>
        /// Get the paymentToken
        /// </summary>
        /// <returns>String</returns>
        public String paymentToken()
        {
            return this.getProperty(CustomerVaultConstants.paymentToken);
        }

        /// <summary>
        /// Set the paymentToken
        /// </summary>
        /// <returns>void</returns>
        public void paymentToken(String data)
        {
            this.setProperty(CustomerVaultConstants.paymentToken, data);
        }

        /// <summary>
        /// Get the timeToLiveSeconds
        /// </summary>
        /// <returns>String</returns>
        public int timeToLiveSeconds()
        {
            return this.getProperty(CustomerVaultConstants.timeToLiveSeconds);
        }

        /// <summary>
        /// Set the timeToLiveSeconds
        /// </summary>
        /// <returns>void</returns>
        public void timeToLiveSeconds(String data)
        {
            this.setProperty(CustomerVaultConstants.timeToLiveSeconds, data);
        }

        /// <summary>
        /// Get the card
        /// </summary>
        /// <returns>Card</returns>
        public Card card()
        {
            return this.getProperty(CustomerVaultConstants.card);
        }

        
        /// <summary>
        /// Get the error
        /// </summary>
        /// <returns>OptError</returns>
        public OptError error()
        {
            return this.getProperty(CustomerVaultConstants.error);
        }

        /// <summary>
        /// Set the error
        /// </summary>
        /// <returns>void</returns>
        public void error(OptError data)
        {
            this.setProperty(CustomerVaultConstants.error, data);
        }

        /// <summary>
        /// Get the links
        /// </summary>
        /// <returns>List<Link></returns>
        public List<Link> links()
        {
            return this.getProperty(CustomerVaultConstants.links);
        }

        /// <summary>
        /// Set the links
        /// </summary>
        /// <returns>void</returns>
        public void links(List<Link> data)
        {
            this.setProperty(CustomerVaultConstants.links, data);
        }

        /// <summary>
        /// Get the billingAddress
        /// </summary>
        /// <returns>List<Link></returns>
        public BillingAddress billingAddress()
        {
            return this.getProperty(CustomerVaultConstants.billingAddress);
        }

        /// <summary>
        /// Set the billingAddress
        /// </summary>
        /// <returns>void</returns>
        public void billingAddress(BillingAddress data)
        {
            this.setProperty(CustomerVaultConstants.billingAddress, data);
        }

        public static CardTokenBuilder Builder()
        {
            return new CardTokenBuilder();
        }

        /// <summary>
        /// CardBuilder will allow an authorization to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated Card object
        /// </summary>
        public class CardTokenBuilder : BaseJSONBuilder<CardToken>
        {
            /// <summary>
            /// Build a card object within this CardToken.
            /// </summary>
            /// <returns>Profile.profileBuilder<VerificationBuilder></returns>
            public Card.CardBuilderSingelUse<CardTokenBuilder> card()
            {
                if (!this.properties.ContainsKey(CustomerVaultConstants.card))
                {
                    this.properties[CustomerVaultConstants.card] = new Card.CardBuilderSingelUse<CardTokenBuilder>(this);
                }
                return this.properties[CustomerVaultConstants.card] as Card.CardBuilderSingelUse<CardTokenBuilder>;
            }

            /// <summary>
            /// Build an BillingAddressBuilder object within this authorization.
            /// </summary>
            /// <returns>BillingAddress.BillingAddressBuilder<CardBuilder></returns>
            public BillingAddress.BillingAddressBuilder<CardTokenBuilder> billingAddress()
            {
                if (!this.properties.ContainsKey(CustomerVaultConstants.billingAddress))
                {
                    this.properties[CustomerVaultConstants.billingAddress] = new BillingAddress.BillingAddressBuilder<CardTokenBuilder>(this);
                }
                return this.properties[CustomerVaultConstants.billingAddress] as BillingAddress.BillingAddressBuilder<CardTokenBuilder>;
            }
        }
    }
}
