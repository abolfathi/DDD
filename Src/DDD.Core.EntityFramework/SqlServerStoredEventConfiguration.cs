﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Core.Infrastructure.Data
{
    using Domain;

    public class SqlServerStoredEventConfiguration : StoredEventConfiguration
    {

        #region Methods

        public override void Configure(EntityTypeBuilder<StoredEvent> builder)
        {
            base.Configure(builder);
            // Fields
            builder.Property(e => e.Id)
                   .HasDefaultValueSql("NEXT VALUE FOR EventId");
            builder.Property(e => e.OccurredOn)
                   .HasColumnType("datetime2(3)"); // in milliseconds
            builder.Property(e => e.Body)
                   .HasColumnType("xml");
        }

        #endregion Methods

    }
}