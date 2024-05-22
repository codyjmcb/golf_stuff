<?php
	namespace App\Controller;

	use PDO;

	class XXXXController
	{
		private $user = "user";
		private $password = "password";
		private $database = "test_database";
		private $table = "XXXX";

		public function getXXXXs()
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

		public function getXXXX()
		{
			$headers = getallheaders();

			$xxxx = isset($headers['xxxx']) ? $headers['xxxx'] : null;

			try
			{
				$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
				$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
				$stmt = $db->query("SELECT * FROM $this->table WHERE xxxx = \"$xxxx\"");
				$row = $stmt->fetch(PDO::FETCH_ASSOC);
				return json_encode($row);
			}
			catch (PDOException $e)
			{
				print "Error!: " . $e->getMessage();
				die();
			}
		}

		public function addXXXX()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$xxxx = $data['xxxx'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "INSERT INTO $this->table VALUES (\"$xxxx\")";
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

		public function updateXXXX()
		{
			$rawData = file_get_contents('php://input');

			// Decode the JSON data
			$data = json_decode($rawData, true);

			// Access the data
			$xxxx = $data['xxxx'] ?? null;

			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);
			$query = "UPDATE $this->table SET xxxx = \"$xxxx\" WHERE xxxx = \"$xxxx\"";
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

		public function deleteXXXX()
		{
			$headers = getallheaders();
			$xxxx = isset($headers['xxxx']) ? $headers['xxxx'] : null;
			$db = new PDO("mysql:host=localhost;dbname=$this->database", $this->user, $this->password);
			$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_WARNING);

			$query = "DELETE FROM $this->table WHERE xxxx = \"$xxxx\"";
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