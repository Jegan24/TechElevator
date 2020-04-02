<template>

  <div id="app">    
    <the-header>  <!-- Step 3A --> 
    </the-header> <!-- Step 3B -->
  </div>
</template>

<script>
import TheHeader from "@/components/TheHeader" // Step 1

export default {
  name: "app",
  components: {
    TheHeader // Step 2
  }
};
</script>

<style>
body {
  margin: 0px;
  padding: 0px;
}
#app {
  display: grid;
  grid-template-columns: 150px auto 150px;
  grid-template-rows: 60px 1fr 100px;
  grid-gap: 1em;
  height: 100vh;
}

header,
aside,
article,
footer {
  background: #eaeaea;
  padding: 1em;
  color: #949494;
}

header,
footer {
  grid-column: 1 / 4;
}
</style>