<?php

	namespace App\Controller;

	use PDO;

	class GolferController
	{
		private $user = "user";
		private $password = "password";
		private $database = "test_database";
		private $table = "GOLFERS";

		public function getGolfers()
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

		public function getGolfer()
		{
			$headers = getallheaders();

			$golferId = isset($headers['golferId']) ? $headers['golferId'] : null;

			try
			{
				$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
				$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
				$stmt = $db->query("SELECT * FROM $this->table WHERE golferId = \"$golferId\"");
				$row = $stmt->fetch(PDO::FETCH_ASSOC);
				return json_encode($row);
			}
			catch (PDOException $e)
			{
				print "Error!: " . $e->getMessage();
				die();
			}
		}

		public function addGolfer()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$golferId = $data['golferId'] ?? null;
			$firstName = $data['firstName'] ?? null;
			$middleInitial = $data['middleInitial'] ?? null;
			$lastName = $data['lastName'] ?? null;
			$handicap = $data['handicap'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "INSERT INTO $this->table VALUES (\"$golferId\", \"$firstName\", \"$middleInitial\", \"$lastName\", $handicap)";
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

		public function updateGolfer()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$golferId = $data['golferId'] ?? null;
			$firstName = $data['firstName'] ?? null;
			$middleInitial = $data['middleInitial'] ?? null;
			$lastName = $data['lastName'] ?? null;
			$handicap = $data['handicap'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "UPDATE $this->table SET firstName = \"$firstName\", middleInitial = \"$middleInitial\", lastName = \"$lastName\", handicap = $handicap WHERE golferId = \"$golferId\"";
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

		public function deleteGolfer()
		{
			$headers = getallheaders();
			$golferId = isset($headers['golferId']) ? $headers['golferId'] : null;
			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);

			$query = "DELETE FROM $this->table WHERE golferId = \"$golferId\"";
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
	}
?>
