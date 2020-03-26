<template>
  <div id="app">
    <!-- step 3 use the component by adding the custom element to the markdown-->
    <the-header></the-header> 
    <left-side-bar></left-side-bar>
    <main-content></main-content>
    <aside class="sidebar-right">Right Sidebar</aside>
    <footer>Footer</footer>
  </div>
</template>

<script>

// step 1 import your component
import TheHeader from "@/components/TheHeader"
import LeftSideBar from "@/components/LeftSideBar"
import MainContent from "@/components/MainContent"

export default {
  name: "app",
  components: {
    TheHeader, //step 2 add it to the components block
    LeftSideBar,
    MainContent
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