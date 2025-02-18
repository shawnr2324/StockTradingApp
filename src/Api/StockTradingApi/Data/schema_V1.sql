-- User Table
CREATE TABLE Users (
    UserId UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    Username VARCHAR(50) UNIQUE NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Stock Table
CREATE TABLE Stocks (
    StockId UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    Symbol VARCHAR(10) UNIQUE NOT NULL,
    CompanyName VARCHAR(100) NOT NULL,
    Exchange VARCHAR(50),
    CurrentPrice DECIMAL(18,2),
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Industry Table
CREATE TABLE Industries (
    IndustryId UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    Name VARCHAR(50) UNIQUE NOT NULL
);

-- StockIndustry (Many-to-Many Relationship)
CREATE TABLE StockIndustries (
    StockId UUID REFERENCES Stocks(StockId) ON DELETE CASCADE,
    IndustryId UUID REFERENCES Industries(IndustryId) ON DELETE CASCADE,
    PRIMARY KEY (StockId, IndustryId)
);

-- Portfolio Table
CREATE TABLE Portfolios (
    PortfolioId UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    UserId UUID REFERENCES Users(UserId) ON DELETE CASCADE,
    StockId UUID REFERENCES Stocks(StockId) ON DELETE CASCADE,
    SharesOwned DECIMAL(18,4) DEFAULT 0,
    AverageBuyPrice DECIMAL(18,2) DEFAULT 0
);

-- Trade Table
CREATE TABLE Trades (
    TradeId UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    UserId UUID REFERENCES Users(UserId) ON DELETE CASCADE,
    StockId UUID REFERENCES Stocks(StockId) ON DELETE CASCADE,
    TradeType VARCHAR(10) CHECK (TradeType IN ('Buy', 'Sell')),
    Quantity DECIMAL(18,4),
    DollarAmount DECIMAL(18,2),
    TradeStatus VARCHAR(20),
    ExecutedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Order Table
CREATE TABLE Orders (
    OrderId UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    UserId UUID REFERENCES Users(UserId) ON DELETE CASCADE,
    StockId UUID REFERENCES Stocks(StockId) ON DELETE CASCADE,
    OrderTypeId INT REFERENCES OrderTypes(OrderTypeId),
    LimitPrice DECIMAL(18,2),
    Quantity DECIMAL(18,4),
    OrderStatusId INT REFERENCES OrderStatuses(OrderStatusId),
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- TransactionHistory Table
CREATE TABLE TransactionHistory (
    TransactionId UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    UserId UUID REFERENCES Users(UserId) ON DELETE CASCADE,
    StockId UUID REFERENCES Stocks(StockId) ON DELETE CASCADE,
    TransactionTypeId INT REFERENCES TransactionTypes(TransactionTypeId),
    Amount DECIMAL(18,2),
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Watchlist Table
CREATE TABLE Watchlists (
    WatchlistId UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    UserId UUID REFERENCES Users(UserId) ON DELETE CASCADE,
    StockId UUID REFERENCES Stocks(StockId) ON DELETE CASCADE
);

-- Notification Table
CREATE TABLE Notifications (
    NotificationId UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    UserId UUID REFERENCES Users(UserId) ON DELETE CASCADE,
    Message TEXT NOT NULL,
    IsRead BOOLEAN DEFAULT FALSE,
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Dividend Table
CREATE TABLE Dividends (
    DividendId UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    StockId UUID REFERENCES Stocks(StockId) ON DELETE CASCADE,
    UserId UUID REFERENCES Users(UserId) ON DELETE CASCADE,
    DividendAmount DECIMAL(18,4),
    ExDate DATE,
    PayDate DATE
);

-- OptionsContract Table
CREATE TABLE OptionsContracts (
    OptionId UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    StockId UUID REFERENCES Stocks(StockId) ON DELETE CASCADE,
    TypeId INT REFERENCES OptionsContractTypes(OptionTypeId),
    StrikePrice DECIMAL(18,2),
    ExpirationDate DATE
);

-- Reference Tables for Different Types
CREATE TABLE OrderTypes (
    OrderTypeId SERIAL PRIMARY KEY,
    Name VARCHAR(20) UNIQUE NOT NULL
);

CREATE TABLE OrderStatuses (
    OrderStatusId SERIAL PRIMARY KEY,
    Name VARCHAR(20) UNIQUE NOT NULL
);

CREATE TABLE TransactionTypes (
    TransactionTypeId SERIAL PRIMARY KEY,
    Name VARCHAR(20) UNIQUE NOT NULL
);

CREATE TABLE OptionsContractTypes (
    OptionTypeId SERIAL PRIMARY KEY,
    Name VARCHAR(10) UNIQUE NOT NULL CHECK (Name IN ('Call', 'Put'))
);

-- Insert Default Data
INSERT INTO OrderTypes (Name) VALUES ('Market'), ('Limit'), ('Stop'), ('Stop Limit');
INSERT INTO OrderStatuses (Name) VALUES ('Pending'), ('Executed'), ('Canceled');
INSERT INTO TransactionTypes (Name) VALUES ('Deposit'), ('Withdraw'), ('Dividend'), ('TradeExecution');
INSERT INTO OptionsContractTypes (Name) VALUES ('Call'), ('Put');
