<?php

	require_once '../src/Router.php';
	require_once '../src/Controllers/ApiController.php';
	require_once '../src/Controllers/GolferController.php';

	$router = new Router();

	// Define routes
	$router->add('GET', '/', 'ApiController@getHome');
	$router->add('GET', '/home', 'ApiController@getHome');
	$router->add('GET', '/test', 'ApiController@getJson');
	$router->add('GET', '/about', 'ApiController@getAbout');
	$router->add('GET', '/golfers', 'GolferController@getGolfers');
	$router->add('GET', '/golfer', 'GolferController@getGolfer');

	$router->add('POST', '/golfer', 'GolferController@addGolfer');
	$router->add('PUT', '/golfer', 'GolferController@updateGolfer');
	$router->add('DELETE', '/golfer', 'GolferController@deleteGolfer');

	// run the router
	$method = $_SERVER['REQUEST_METHOD'];
	$uri = parse_url($_SERVER['REQUEST_URI'], PHP_URL_PATH);
	echo $router->dispatch($method, $uri);
?>
