USE [Test]
GO
EXEC spClearDatabase
GO
INSERT INTO [dbo].[Command] ([CommandId], [CommandType], [Body], [BodyFormat], [RecurringExpression], [LastExecutionTime], [LastExecutionStatus], [LastExceptionInfo])
VALUES (N'36beb37d-1e01-bb7d-fb2a-3a0044745345', N'DDD.Core.Application.FakeCommand1, DDD.Core.Messages', '{"Property1":"dummy","Property2":10}', N'JSON', N'* * * * *', CAST(N'2022-01-01T00:00:00.0000000' AS DateTime2), N'F', N'System.TimeoutException: The operation has timed-out.')
GO
INSERT INTO [dbo].[Command] ([CommandId], [CommandType], [Body], [BodyFormat], [RecurringExpression], [LastExecutionTime], [LastExecutionStatus], [LastExceptionInfo])
VALUES (N'f7df5bd0-8763-677e-7e6b-3a0044746810', N'DDD.Core.Application.FakeCommand2, DDD.Core.Messages', '{"Property1":"dummy","Property2":10,"Property3":"2022-12-24T14:49:44.361964+01:00"}', N'JSON', N'0  0 1 * *', NULL, NULL, NULL)
GO