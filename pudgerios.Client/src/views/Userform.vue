<template>
	<form @submit.prevent='submit'>
		
	</form>
</template>

<script>
	import Navbar from '../components/Navbar.vue'
	import Footer from '../components/Footer.vue'

	export default {
		components: {
			Navbar,
			Footer
		},
		methods: {
			submit(){
				console.log('tomorrow..');
			}
		}
	}
</script>
