INSERT INTO Event
           (EventId,
            EventType,
            OccurredOn,
            Body,
            BodyFormat,
            StreamId,
            StreamType,
            IssuedBy)
     VALUES
           (@EventId,
            @EventType,
            @OccurredOn,
            @Body,
            @BodyFormat,
            @StreamId,
            @StreamType,
            @IssuedBy)