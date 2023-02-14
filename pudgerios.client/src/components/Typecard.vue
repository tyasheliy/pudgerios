<template>
	<div class='type-card text-dark'>
		<img :src='validate_image_src()' />
		<div class='type-card-body'>
			<p class='type-card-caption'>{{caption}}</p>
			<span class='type-card-view'>
				<img src='../static/img/view.jpg' />
				{{view}}
			</span>
			<span class='type-card-size'>
				<img src='../static/img/size.jpg' />
				{{size}}
			</span>
			<span class='type-card-suits'>
				<img src='../static/img/suits.jpg' />
				{{suits}}
			</span>
			<span class='type-card-food'>
				<img src='../static/img/food.jpg' />
				{{food}}
			</span>
		</div>
		<div class='type-card-footer'>
			<a :href='link' class='btn btn-light shadow' role='button'>{{validate_button_text()}}</a>
		</div>
	</div>
</template>

<script>
	export default {
		props: {
			image: String,
			caption: String,
			view: String,
			size: String,
			suits: String,
			food: String,
			link: String,
			button_text: String,
		},
		methods: {
			validate_button_text(){
				if (this.button_text === undefined){
					return "Подробнее";
				}
				return this.button_text;
			},
			validate_image_src(){
				try {
					return require("../static/img/" + this.image);
				}
				catch {
					return require("../static/img/luxe.png");
				}
			},
		}
	}
</script>

<style scoped>
	.type-card {
		position: relative;
		top: 0;
		left: 0;
		width: 100%;
		height: 100%;
		background: white;
	}

	.type-card img {
		display: block;
		position: relative;
		top: 0;
		left: 0;
		width: 100%;
		height: 50%;
		filter: none;
		z-index: 1;
	}

	.type-card-caption {
		font-weight: bold;
		font-size: 150%;
	}

	.type-card-body {
		position: relative;
		top: 0;
		left: 0;
		width: 100%;
		height: 40%;
	}

	.type-card-body span {
		display: block;
		margin: 0 1% 0 1%;
	}
	
	.type-card-body img {
		display: inline;
		width: 27px;
		height: 27px;
		z-index: 1;
	}

	.type-card-footer {
		position: relative;
		top: 0;
		left: 0;
		width: 100%;
		height: 10%;
	}
</style>
