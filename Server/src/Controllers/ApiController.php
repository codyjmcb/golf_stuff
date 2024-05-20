<?php

	namespace App\Controller;

	class ApiController
	{
		public function getString()
		{
			return "Hello, this is a test string!";
		}

		public function getJson()
		{
			header('Content-Type: application/json');
			return json_encode(['message' => 'Hello, this is a JSON response!']);
		}
	}

?>
