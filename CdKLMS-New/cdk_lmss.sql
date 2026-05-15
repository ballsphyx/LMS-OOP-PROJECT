-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 15, 2026 at 09:34 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cdk_lms`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `admin_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`admin_id`, `user_id`) VALUES
(11, 29),
(12, 34),
(13, 38);

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `book_id` int(11) NOT NULL,
  `book_title` varchar(255) NOT NULL,
  `book_author` varchar(255) NOT NULL,
  `category_id` int(11) NOT NULL,
  `published_year` int(11) NOT NULL,
  `isbn` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`book_id`, `book_title`, `book_author`, `category_id`, `published_year`, `isbn`) VALUES
(31, 'DeleteFalseBorrowed', 'test', 2, 2026, '1233211232'),
(32, 'FutureBook', 'test', 1, 2026, '1233212231'),
(36, 'testbook', 'zee', 1, 2026, '1233451232'),
(37, 'testbook', 'zee', 1, 2026, '1233431232'),
(38, 'testbook', 'zee', 1, 2026, '1223431232'),
(39, 'testscience', 'zee', 4, 2026, '0982346872');

-- --------------------------------------------------------

--
-- Table structure for table `book_copies`
--

CREATE TABLE `book_copies` (
  `copy_id` int(11) NOT NULL,
  `book_id` int(11) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'available'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `book_copies`
--

INSERT INTO `book_copies` (`copy_id`, `book_id`, `status`) VALUES
(107, 31, 'Borrowed'),
(108, 31, 'Borrowed'),
(109, 32, 'Available'),
(110, 32, 'Available'),
(120, 36, 'Available'),
(121, 36, 'Available'),
(122, 36, 'Available'),
(123, 37, 'Available'),
(124, 37, 'Available'),
(125, 37, 'Available'),
(126, 38, 'Available'),
(127, 38, 'Available'),
(128, 38, 'Available'),
(129, 39, 'Borrowed'),
(130, 39, 'Borrowed'),
(131, 39, 'Borrowed'),
(132, 39, 'Borrowed'),
(133, 39, 'Borrowed'),
(134, 39, 'Borrowed'),
(135, 39, 'Borrowed'),
(136, 39, 'Borrowed'),
(137, 39, 'Borrowed'),
(138, 39, 'Available'),
(139, 39, 'Borrowed'),
(140, 39, 'Borrowed'),
(141, 39, 'Borrowed'),
(142, 39, 'Borrowed'),
(143, 39, 'Borrowed'),
(144, 39, 'Borrowed'),
(145, 39, 'Borrowed'),
(146, 39, 'Available'),
(147, 39, 'Borrowed'),
(148, 39, 'Borrowed'),
(149, 39, 'Borrowed'),
(150, 39, 'Borrowed'),
(151, 39, 'Borrowed');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `category_id` int(11) NOT NULL,
  `category_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`category_id`, `category_name`) VALUES
(1, 'Romance'),
(2, 'Fiction'),
(3, 'NonFiction'),
(4, 'Science'),
(5, 'History'),
(6, 'Biography'),
(7, 'Fantasy'),
(8, 'Mystery'),
(9, 'Horror'),
(10, 'SelfHelp'),
(11, 'Philosophy'),
(12, 'Religion'),
(13, 'Technology');

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

CREATE TABLE `departments` (
  `department_id` int(11) NOT NULL,
  `department_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`department_id`, `department_name`) VALUES
(1, 'Information Technology'),
(2, 'Education'),
(3, 'Nursing'),
(4, 'Criminology'),
(5, 'Hospital Management');

-- --------------------------------------------------------

--
-- Table structure for table `instructors`
--

CREATE TABLE `instructors` (
  `instructor_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `dept_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `instructors`
--

INSERT INTO `instructors` (`instructor_id`, `user_id`, `dept_id`) VALUES
(10, 32, 3),
(11, 36, 1),
(12, 39, 3);

-- --------------------------------------------------------

--
-- Table structure for table `programs`
--

CREATE TABLE `programs` (
  `program_id` int(11) NOT NULL,
  `program_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `programs`
--

INSERT INTO `programs` (`program_id`, `program_name`) VALUES
(1, 'BSIT'),
(2, 'BSED'),
(3, 'BSCRIM'),
(4, 'BSN'),
(5, 'BSHM');

-- --------------------------------------------------------

--
-- Table structure for table `roles`
--

CREATE TABLE `roles` (
  `role_id` int(11) NOT NULL,
  `role_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `roles`
--

INSERT INTO `roles` (`role_id`, `role_name`) VALUES
(1, 'Admin'),
(2, 'Instructor'),
(3, 'Student');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `student_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `year_level` varchar(11) NOT NULL,
  `program_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`student_id`, `user_id`, `year_level`, `program_id`) VALUES
(10, 33, '3rd Year', 1),
(11, 35, '2nd Year', 1),
(12, 37, '1st Year', 1);

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `transaction_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `copy_id` int(11) NOT NULL,
  `date_borrowed` timestamp NOT NULL DEFAULT current_timestamp(),
  `due_date` datetime NOT NULL,
  `date_returned` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`transaction_id`, `user_id`, `copy_id`, `date_borrowed`, `due_date`, `date_returned`) VALUES
(47, 37, 109, '2026-05-14 15:20:46', '2026-05-21 23:20:46', '2026-05-15 13:35:55'),
(48, 37, 108, '2026-05-14 15:57:12', '2026-05-21 23:57:12', NULL),
(49, 37, 129, '2026-05-15 02:18:16', '2026-05-22 10:18:16', NULL),
(50, 36, 130, '2026-05-15 02:19:48', '2026-05-22 10:19:48', NULL),
(51, 36, 131, '2026-05-15 02:19:48', '2026-05-22 10:19:48', NULL),
(52, 36, 132, '2026-05-15 02:19:48', '2026-05-22 10:19:48', NULL),
(53, 36, 133, '2026-05-15 02:19:48', '2026-05-22 10:19:48', NULL),
(54, 36, 134, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(55, 36, 135, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(56, 36, 136, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(57, 36, 137, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(58, 36, 138, '2026-05-15 02:19:49', '2026-05-22 10:19:49', '2026-05-15 13:36:32'),
(59, 36, 139, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(60, 36, 140, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(61, 36, 141, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(62, 36, 142, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(63, 36, 143, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(64, 36, 144, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(65, 36, 145, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(66, 36, 146, '2026-05-15 02:19:49', '2026-05-22 10:19:49', '2026-05-15 13:36:35'),
(67, 36, 147, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(68, 36, 148, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(69, 36, 149, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(70, 36, 150, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL),
(71, 36, 151, '2026-05-15 02:19:49', '2026-05-22 10:19:49', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `full_name`, `username`, `password`, `role_id`) VALUES
(29, 'admin', 'admin', 'admin', 1),
(32, 'test', 'test', 'test', 2),
(33, 'testtwo', 'test2', 'test2', 3),
(34, 'testthree', 'test3', 'test3', 1),
(35, 'test', 'teset35', 'test', 3),
(36, 'instructor', 'instructor', 'instructor', 2),
(37, 'student', 'student', 'student', 3),
(38, 'admintest', 'admintest', 'admin', 1),
(39, 'instructortest', 'instructortest', 'test', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`admin_id`),
  ADD UNIQUE KEY `user_id` (`user_id`);

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`book_id`),
  ADD KEY `category_id` (`category_id`);

--
-- Indexes for table `book_copies`
--
ALTER TABLE `book_copies`
  ADD PRIMARY KEY (`copy_id`),
  ADD KEY `book_id` (`book_id`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`category_id`);

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`department_id`);

--
-- Indexes for table `instructors`
--
ALTER TABLE `instructors`
  ADD PRIMARY KEY (`instructor_id`),
  ADD UNIQUE KEY `user_id` (`user_id`),
  ADD KEY `dept_id` (`dept_id`);

--
-- Indexes for table `programs`
--
ALTER TABLE `programs`
  ADD PRIMARY KEY (`program_id`);

--
-- Indexes for table `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`role_id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`student_id`),
  ADD UNIQUE KEY `user_id` (`user_id`),
  ADD KEY `course_id` (`program_id`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `copy_id` (`copy_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD KEY `role_id` (`role_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admins`
--
ALTER TABLE `admins`
  MODIFY `admin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `book_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT for table `book_copies`
--
ALTER TABLE `book_copies`
  MODIFY `copy_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=221;

--
-- AUTO_INCREMENT for table `departments`
--
ALTER TABLE `departments`
  MODIFY `department_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `instructors`
--
ALTER TABLE `instructors`
  MODIFY `instructor_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `programs`
--
ALTER TABLE `programs`
  MODIFY `program_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `roles`
--
ALTER TABLE `roles`
  MODIFY `role_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `student_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admins`
--
ALTER TABLE `admins`
  ADD CONSTRAINT `admins_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE;

--
-- Constraints for table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `books_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `categories` (`category_id`);

--
-- Constraints for table `book_copies`
--
ALTER TABLE `book_copies`
  ADD CONSTRAINT `book_copies_ibfk_1` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`) ON DELETE CASCADE;

--
-- Constraints for table `instructors`
--
ALTER TABLE `instructors`
  ADD CONSTRAINT `instructors_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `instructors_ibfk_2` FOREIGN KEY (`dept_id`) REFERENCES `departments` (`department_id`);

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `students_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `students_ibfk_2` FOREIGN KEY (`program_id`) REFERENCES `programs` (`program_id`);

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `transactions_ibfk_2` FOREIGN KEY (`copy_id`) REFERENCES `book_copies` (`copy_id`);

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `roles` (`role_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
