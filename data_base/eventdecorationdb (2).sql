-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 21, 2026 at 06:46 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eventdecorationdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `assignedstaff`
--

CREATE TABLE `assignedstaff` (
  `AssignID` int(11) NOT NULL,
  `EventID` varchar(20) NOT NULL,
  `StaffID` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `assignedstaff`
--

INSERT INTO `assignedstaff` (`AssignID`, `EventID`, `StaffID`) VALUES
(1, 'b123', 's123'),
(2, 'b123', 's12345');

-- --------------------------------------------------------

--
-- Table structure for table `bookingitems`
--

CREATE TABLE `bookingitems` (
  `BookingItemID` int(11) NOT NULL,
  `BookingID` varchar(20) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `AssignedDate` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bookingitems`
--

INSERT INTO `bookingitems` (`BookingItemID`, `BookingID`, `ItemID`, `Quantity`, `AssignedDate`) VALUES
(2, 'b123', 2, 100, '2026-06-21 11:28:30'),
(3, 'b123', 3, 10, '2026-06-21 14:38:06'),
(4, 'B001', 3, 100, '2026-06-21 14:44:46');

-- --------------------------------------------------------

--
-- Table structure for table `bookings`
--

CREATE TABLE `bookings` (
  `BookingID` varchar(20) NOT NULL,
  `CustomerID` varchar(20) NOT NULL,
  `PackageID` varchar(20) DEFAULT NULL,
  `EventType` varchar(50) NOT NULL,
  `EventDate` date NOT NULL,
  `EventTime` time NOT NULL,
  `MobileNumber` varchar(15) DEFAULT NULL,
  `TotalAmount` decimal(10,2) NOT NULL,
  `Advance` decimal(10,2) NOT NULL DEFAULT 0.00,
  `PaymentStatus` enum('Paid','Pending','Partial') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bookings`
--

INSERT INTO `bookings` (`BookingID`, `CustomerID`, `PackageID`, `EventType`, `EventDate`, `EventTime`, `MobileNumber`, `TotalAmount`, `Advance`, `PaymentStatus`) VALUES
('B001', '123', 'ba123', '', '2026-06-21', '11:31:56', '0754466195', 200000.00, 100000.00, 'Partial'),
('b123', '123', 'ba123', '', '2026-06-20', '23:33:11', '0701170446', 5400.00, 1000.00, 'Partial'),
('b222', '123', 'ba123', '', '2026-06-21', '16:57:26', '0703365442', 3000.00, 200.00, 'Partial');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustomerID` varchar(20) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `MobileNumber` varchar(15) NOT NULL,
  `Address` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerID`, `FirstName`, `LastName`, `Email`, `MobileNumber`, `Address`) VALUES
('123', 'hashan', 'dew', 'hashan@gmail.com', '0701170337', 'fcuhfuhcu'),
('user123', 'Hashan', 'devinda', 'hashan@gmail.com', '0701128665', 'hgvhyvhfujvyjy');

-- --------------------------------------------------------

--
-- Table structure for table `eventitems`
--

CREATE TABLE `eventitems` (
  `EventItemID` int(11) NOT NULL,
  `BookingID` varchar(20) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `AssignedDate` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `eventitems`
--

INSERT INTO `eventitems` (`EventItemID`, `BookingID`, `ItemID`, `Quantity`, `AssignedDate`) VALUES
(1, 'b123', 1, 10, '2026-06-21 10:52:12');

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `ItemID` int(11) NOT NULL,
  `ItemName` varchar(100) NOT NULL,
  `Quantity` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`ItemID`, `ItemName`, `Quantity`) VALUES
(1, 'chair', 90),
(2, 'chari2', 200),
(3, 'hello', 390);

-- --------------------------------------------------------

--
-- Table structure for table `packages`
--

CREATE TABLE `packages` (
  `PackageID` varchar(20) NOT NULL,
  `PackageName` varchar(100) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `PackageItems` text DEFAULT NULL,
  `Description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `packages`
--

INSERT INTO `packages` (`PackageID`, `PackageName`, `Price`, `PackageItems`, `Description`) VALUES
('ba123', 'hello', 34500.00, NULL, NULL),
('ba1235', 'hass', 23999.00, 'duhwbiudhgw', '3dwedweqdweqdeqwde'),
('ba34', 'hello2', 45000.00, 'ecfedcvefcv', 'dewfderfcerf');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `StaffID` varchar(20) NOT NULL,
  `FullName` varchar(100) NOT NULL,
  `Position` varchar(50) NOT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `MobileNumber` varchar(15) NOT NULL,
  `Address` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`StaffID`, `FullName`, `Position`, `Email`, `MobileNumber`, `Address`) VALUES
('s123', 'hashan devinda', 'Event Manager', 'hashan@gmail.com', '0701170337', 'djcbjdhygbc ydhgvb yhdcgv yvdc'),
('s12345', 'hashandevindag', 'Photographer', 'ghuyguyg@gmail.com', '07011703546', 'ugbhugybyg');

-- --------------------------------------------------------

--
-- Table structure for table `staffassignments`
--

CREATE TABLE `staffassignments` (
  `AssignmentID` int(11) NOT NULL,
  `BookingID` varchar(20) NOT NULL,
  `StaffID` varchar(20) NOT NULL,
  `AssignedDate` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Role` enum('Admin','Staff') NOT NULL DEFAULT 'Admin',
  `CreatedDate` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Username`, `Password`, `Role`, `CreatedDate`) VALUES
(1, 'dulari123', 'dulari@123', 'Admin', '2026-06-18 11:23:43');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `assignedstaff`
--
ALTER TABLE `assignedstaff`
  ADD PRIMARY KEY (`AssignID`),
  ADD UNIQUE KEY `unique_assignment` (`EventID`,`StaffID`),
  ADD KEY `StaffID` (`StaffID`);

--
-- Indexes for table `bookingitems`
--
ALTER TABLE `bookingitems`
  ADD PRIMARY KEY (`BookingItemID`),
  ADD KEY `BookingID` (`BookingID`),
  ADD KEY `ItemID` (`ItemID`);

--
-- Indexes for table `bookings`
--
ALTER TABLE `bookings`
  ADD PRIMARY KEY (`BookingID`),
  ADD KEY `CustomerID` (`CustomerID`),
  ADD KEY `PackageID` (`PackageID`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `eventitems`
--
ALTER TABLE `eventitems`
  ADD PRIMARY KEY (`EventItemID`),
  ADD KEY `BookingID` (`BookingID`),
  ADD KEY `ItemID` (`ItemID`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `packages`
--
ALTER TABLE `packages`
  ADD PRIMARY KEY (`PackageID`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`StaffID`);

--
-- Indexes for table `staffassignments`
--
ALTER TABLE `staffassignments`
  ADD PRIMARY KEY (`AssignmentID`),
  ADD UNIQUE KEY `BookingID` (`BookingID`,`StaffID`),
  ADD KEY `StaffID` (`StaffID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `assignedstaff`
--
ALTER TABLE `assignedstaff`
  MODIFY `AssignID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `bookingitems`
--
ALTER TABLE `bookingitems`
  MODIFY `BookingItemID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `eventitems`
--
ALTER TABLE `eventitems`
  MODIFY `EventItemID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `ItemID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `staffassignments`
--
ALTER TABLE `staffassignments`
  MODIFY `AssignmentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `assignedstaff`
--
ALTER TABLE `assignedstaff`
  ADD CONSTRAINT `assignedstaff_ibfk_1` FOREIGN KEY (`EventID`) REFERENCES `bookings` (`BookingID`) ON DELETE CASCADE,
  ADD CONSTRAINT `assignedstaff_ibfk_2` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE;

--
-- Constraints for table `bookingitems`
--
ALTER TABLE `bookingitems`
  ADD CONSTRAINT `bookingitems_ibfk_1` FOREIGN KEY (`BookingID`) REFERENCES `bookings` (`BookingID`),
  ADD CONSTRAINT `bookingitems_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `inventory` (`ItemID`);

--
-- Constraints for table `bookings`
--
ALTER TABLE `bookings`
  ADD CONSTRAINT `bookings_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customers` (`CustomerID`) ON DELETE CASCADE,
  ADD CONSTRAINT `bookings_ibfk_2` FOREIGN KEY (`PackageID`) REFERENCES `packages` (`PackageID`) ON DELETE SET NULL;

--
-- Constraints for table `eventitems`
--
ALTER TABLE `eventitems`
  ADD CONSTRAINT `eventitems_ibfk_1` FOREIGN KEY (`BookingID`) REFERENCES `bookings` (`BookingID`),
  ADD CONSTRAINT `eventitems_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `inventory` (`ItemID`);

--
-- Constraints for table `staffassignments`
--
ALTER TABLE `staffassignments`
  ADD CONSTRAINT `staffassignments_ibfk_1` FOREIGN KEY (`BookingID`) REFERENCES `bookings` (`BookingID`) ON DELETE CASCADE,
  ADD CONSTRAINT `staffassignments_ibfk_2` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
