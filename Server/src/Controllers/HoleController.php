<?php
	namespace App\Controller;

	use PDO;

	class HoleController
	{
		private $user = "user";
		private $password = "password";
		private $database = "test_database";
		private $table = "HOLE_INFORMATION";

		public function getHoles()
		{
			try
			{
				$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
				$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
				$stmt = $db->query("SELECT * FROM $this->table");
				$rows = $stmt->fetchAll(PDO::FETCH_ASSOC);
				return json_encode($rows);
			}
			catch (PDOException $e)
			{
				print "Error!: " . $e->getMessage();
				die();
			}
		}

		public function getHole()
		{
			$headers = getallheaders();

			$uniqueID = isset($headers['uniqueID']) ? $headers['uniqueID'] : null;

			try
			{
				$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
				$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
				$stmt = $db->query("SELECT * FROM $this->table WHERE uniqueID = \"$uniqueID\"");
				$row = $stmt->fetch(PDO::FETCH_ASSOC);
				return json_encode($row);
			}
			catch (PDOException $e)
			{
				print "Error!: " . $e->getMessage();
				die();
			}
		}

		public function addHole()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$teeID = $data['teeID'] ?? null;
			$holeNumber = $data['holeNumber'] ?? null;
			$yardage = $data['yardage'] ?? null;
			$par = $data['par'] ?? null;
			$handicapRating = $data['handicapRating'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "INSERT INTO HOLE_INFORMATION (teeID, holeNumber, yardage, par, handicapRating) VALUES ($teeID, $holeNumber, $yardage, $par, $handicapRating)";
			$stmt = $db->prepare($query);

			if($stmt->execute())
			{
				return "Success";
			}
			else
			{
				return "Failure";
			}
		}

		public function updateHole()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$uniqueID = $data['uniqueID'] ?? null;
			$teeID = $data['teeID'] ?? null;
			$holeNumber = $data['holeNumber'] ?? null;
			$yardage = $data['yardage'] ?? null;
			$par = $data['par'] ?? null;
			$handicapRating = $data['handicapRating'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "UPDATE $this->table SET teeID = \"$teeID\", holeNumber = \"$holeNumber\", yardage = \"$yardage\", par = \"$par\", handicapRating = \"$handicapRating\" WHERE uniqueID = \"$uniqueID\"";
			$stmt = $db->prepare($query);
			if($stmt->execute())
			{
				return "Success";
			}
			else
			{
				return "Failure";
			}
		}

		public function deleteHole()
		{
			$headers = getallheaders();
			$uniqueID = isset($headers['uniqueID']) ? $headers['uniqueID'] : null;
			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);

			$query = "DELETE FROM $this->table WHERE uniqueID = \"$uniqueID\"";
			$stmt = $db->prepare($query);

			if($stmt->execute())
			{
				return "Success";
			}
			else
			{
				return "Failure";
			}
		}

		public function getHolesForTee()
		{
			$headers = getallheaders();

			$teeID = isset($headers['teeID']) ? $headers['teeID'] : null;

			try
			{
				$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
				$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
				$stmt = $db->query("SELECT * FROM $this->table WHERE teeID = \"$teeID\"");
				$row = $stmt->fetch(PDO::FETCH_ASSOC);
				return json_encode($row);
			}
			catch (PDOException $e)
			{
				print "Error!: " . $e->getMessage();
				die();
			}
		}
	}
?>