<?php

	require_once '../src/Router.php';
	require_once '../src/Controllers/ApiController.php';

	$router = new Router();

	// Define routes
	$router->add('GET', '/', 'ApiController@getString');
	$router->add('GET', '/test', 'ApiController@getJson');

	// run the router
	$method = $_SERVER['REQUEST_METHOD'];
	$uri = parse_url($_SERVER['REQUEST_URI'], PHP_URL_PATH);
	echo $router->dispatch($method, $uri);

?>
