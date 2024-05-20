<?php

	class Router
	{
		private $routes = [];

		public function add($uri, $controllerAction)
		{
			$this->routes[$uri] = $controllerAction;
		}

		public function dispatch($uri)
		{
			if(array_key_exists($uri, $this->routes))
			{
				list($controller, $action) = explode('@', $this->routes[$uri]);

				if(class_exists($controller) && method_exists($controller, $action))
				{
					$controllerInstance = new $controller();
					$controllerInstance->$action();
				}
				else
				{
					$this->send404();
				}
			}
			else
			{
				$this->send404();
			}
		}

		public function send404()
		{
			header("HTTP/1.0 404 Not Found");
			echo "404 Not Found";
		}
	}

?>
