using System;

namespace ShopCET46.WEB.Data.Entities
{
    public interface IEntity
    {
        int Id { get; set; }

        User CreatedBy { get; set; }


        DateTime CreateDate { get; set; }


        DateTime UpdateDate { get; set; }


        User ModifiedBy { get; set; }

    }
}
