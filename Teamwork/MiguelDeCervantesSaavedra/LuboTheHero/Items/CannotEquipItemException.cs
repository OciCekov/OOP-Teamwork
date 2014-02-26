namespace LuboTheHero.Items
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class CannotEquipItemException : ApplicationException
    {
        private EquippableItem item;

        public CannotEquipItemException(string message, EquippableItem item)
            : this(message, item, null, null)
        {
        }

        public CannotEquipItemException(string message, EquippableItem item, uint? itemRestriction)
            : this(message, item, itemRestriction, null)
        {
        }

        public CannotEquipItemException(string message, EquippableItem item, uint? itemRestriction, Exception causeException)
            : base(message, causeException)
        {
            this.Item = item;
            this.ItemRestriction = itemRestriction;
        }

        public EquippableItem Item
        {
            get
            {
                return this.item;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(string.Format("Item passed to {0} cannot be null", this.GetType().Name));
                }
                this.item = value;
            }
        }

        public uint? ItemRestriction { get; private set; }

        public override string Message
        {
            get
            {
                StringBuilder result = new StringBuilder();
                result.AppendLine(base.Message);

                if (this.ItemRestriction != null)
                {
                    result.AppendLine(string.Format("Item type: {0} - restriction: {1}", this.Item.Type.ToString(), this.ItemRestriction));
                }

                result.AppendLine("Item requirements:");                

                foreach (var item in this.Item.Requirements)
                {
                    result.AppendLine(string.Format("{0} - {1}", item.Key, item.Value));
                }

                return result.ToString();
            }
        }
    }
}
