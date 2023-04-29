-- MySQL dump 8.0.30
-- Created on 2023-04-16 19:57:41

USE automotivedb;

DROP TABLE IF EXISTS `carsforsale`;

CREATE TABLE `carsforsale` (
`Serial No.` int(11) NOT NULL AUTO_INCREMENT,
`Unit` varchar(50) NOT NULL,
`Model` varchar(50) NOT NULL,
`Year` int(11) NOT NULL,
`Color` varchar(50) NOT NULL,
`Fuel Type` varchar(50) NOT NULL,
`Type` varchar(50) NOT NULL,
PRIMARY KEY (`Serial No.`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `carsforsale` (`serial_no`, `car_unit`, `car_model`, `car_year`, `car_color`, `car_type`, `engine_size`, `transmission`, `fuel_type`, `price`) VALUES ('10001', 'Toyota', 'Camry', '2022', 'Red', 'Sedan', '2.5L', 'Automatic', 'Gasoline', '2800000.00');
INSERT INTO `carsforsale` (`serial_no`, `car_unit`, `car_model`, `car_year`, `car_color`, `car_type`, `engine_size`, `transmission`, `fuel_type`, `price`) VALUES ('10002', 'Honda', 'Civic', '2022', 'Blue', 'Hatchback', '1.5L', 'CVT', 'Gasoline', '2350000.00');
INSERT INTO `carsforsale` (`serial_no`, `car_unit`, `car_model`, `car_year`, `car_color`, `car_type`, `engine_size`, `transmission`, `fuel_type`, `price`) VALUES ('10003', 'Ford', 'F-150', '2022', 'Gray', 'Truck', '3.5L', 'Automatic', 'Diesel', '4500000.00');
INSERT INTO `carsforsale` (`serial_no`, `car_unit`, `car_model`, `car_year`, `car_color`, `car_type`, `engine_size`, `transmission`, `fuel_type`, `price`) VALUES ('10004', 'Chevrolet', 'Malibu', '2022', 'White', 'Sedan', '1.5L', 'Automatic', 'Gasoline', '2500000.00');
INSERT INTO `carsforsale` (`serial_no`, `car_unit`, `car_model`, `car_year`, `car_color`, `car_type`, `engine_size`, `transmission`, `fuel_type`, `price`) VALUES ('10005', 'BMW', 'X5', '2022', 'Black', 'SUV', '3.0L', 'Automatic', 'Gasoline', '7000000.00');
INSERT INTO `carsforsale` (`serial_no`, `car_unit`, `car_model`, `car_year`, `car_color`, `car_type`, `engine_size`, `transmission`, `fuel_type`, `price`) VALUES ('10006', 'Mercedes-Benz', 'C-Class', '2022', 'Silver', 'Sedan', '2.0L', 'Automatic', 'Gasoline', '5000000.00');
INSERT INTO `carsforsale` (`serial_no`, `car_unit`, `car_model`, `car_year`, `car_color`, `car_type`, `engine_size`, `transmission`, `fuel_type`, `price`) VALUES ('10007', 'Audi', 'Q7', '2022', 'Blue', 'SUV', '3.0L', 'Automatic', 'Gasoline', '6500000.00');
INSERT INTO `carsforsale` (`serial_no`, `car_unit`, `car_model`, `car_year`, `car_color`, `car_type`, `engine_size`, `transmission`, `fuel_type`, `price`) VALUES ('10008', 'Porsche', '911', '2022', 'Red', 'Coupe', '3.0L', 'Automatic', 'Gasoline', '11000000.00');
INSERT INTO `carsforsale` (`serial_no`, `car_unit`, `car_model`, `car_year`, `car_color`, `car_type`, `engine_size`, `transmission`, `fuel_type`, `price`) VALUES ('10009', 'Tesla', 'Model S', '2022', 'White', 'Sedan', 'Electric', 'Automatic', 'Electric', '9500000.00');
INSERT INTO `carsforsale` (`serial_no`, `car_unit`, `car_model`, `car_year`, `car_color`, `car_type`, `engine_size`, `transmission`, `fuel_type`, `price`) VALUES ('11002', 'Jeep', 'Wrangler', '2022', 'Green', 'SUV', '3.6L', 'Manual', 'Gasoline', '3500000.00');
