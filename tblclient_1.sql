-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Oct 07, 2014 at 08:29 PM
-- Server version: 5.5.24-log
-- PHP Version: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `elect2`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblclient`
--

CREATE TABLE IF NOT EXISTS `tblclient` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cocno` varchar(25) NOT NULL,
  `date_received` date NOT NULL,
  `street` varchar(50) NOT NULL,
  `barangay` varchar(50) NOT NULL,
  `city` varchar(50) NOT NULL,
  `zipcode` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `middlename` varchar(50) NOT NULL,
  `company` varchar(50) NOT NULL,
  `position` varchar(50) NOT NULL,
  `birthdate` date NOT NULL,
  `gender` varchar(10) NOT NULL,
  `civilstatus` varchar(10) NOT NULL,
  `bloodtype` varchar(5) NOT NULL,
  `phone` int(15) NOT NULL,
  `mobile` int(15) NOT NULL,
  `units` int(11) NOT NULL,
  `amount` double NOT NULL,
  `status` tinyint(1) NOT NULL,
  `group` varchar(50) NOT NULL,
  PRIMARY KEY (`id`,`cocno`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `tblclient`
--

INSERT INTO `tblclient` (`id`, `cocno`, `date_received`, `street`, `barangay`, `city`, `zipcode`, `firstname`, `lastname`, `middlename`, `company`, `position`, `birthdate`, `gender`, `civilstatus`, `bloodtype`, `phone`, `mobile`, `units`, `amount`, `status`, `group`) VALUES
(4, '11', '2014-10-07', '99', '111', '222', 0, '22', '44', '33', '444', '555', '2000-06-18', '55', '66', 'B', 77, 88, 777, 666, 1, '999');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
