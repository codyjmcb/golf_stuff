<?php

	class Router
	{
		private $routes = [];

		public function add($method, $route, $handler)
		{
			$this->routes[] = [
				'method' => $method,
				'route' => $route,
				'handler' => $handler,
			];
		}

		public function dispatch($method, $uri)
		{
			foreach ($this->routes as $route)
			{
				if($route['method'] === $method && $route['route'] === $uri)
				{
					$handler = $route['handler'];
					list($controller, $action) = explode('@', $handler);
					$controller = "App\\Controller\\$controller";
					$controllerInstance = new $controller();
					return $controllerInstance->$action();
				}
			}
			return $this->send404();
		}

		public function send404()
		{
			header("HTTP/1.0 404 Not Found");
			echo "404 Not Found";
		}
	}

?>
