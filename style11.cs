body {
  font-family: "Source Sans Pro", Helvetica Neue, Helvetica, Arial, sans-serif;
  font-size: 16px;
  line-height: 1.75;
  background-color: whitesmoke;
}

h1 {
  text-transform: uppercase;
  color: #252525;
  text-align: center;
  line-height: 2;
  position: relative;
  text-decoration: none;
}
h1::after {
  content: " ";
  width: 3%;
  height: 2px;
  background-color: #252525;
  position: absolute;
  bottom: 0;
  right: 50%;
  margin-right: -1.5%;
}

#timeline {
  display: flex;
  background-color: #031625;
}
#timeline:hover .tl-item {
  width: 50%;
}

.tl-item {
  transform: translate3d(0, 0, 0);
  position: relative;
  width: 50%;
  height: 100vh;
  min-height: 600px;
  color: #fff;
  overflow: hidden;
  transition: width 0.5s ease;
}
.tl-item:before, .tl-item:after {
  transform: translate3d(0, 0, 0);
  content: "";
  position: absolute;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
}
.tl-item:after {
  background: rgba(3, 22, 37, 0.85);
  opacity: 1;
  transition: opacity 0.5s ease;
}
.tl-item:before {
  background: linear-gradient(to bottom, rgba(0, 0, 0, 0) 0%, rgb(0, 0, 0) 75%);
  z-index: 1;
  opacity: 0;
  transform: translate3d(0, 0, 0) translateY(50%);
  transition: opacity 0.5s ease, transform 0.5s ease;
}
.tl-item:hover {
  width: 57% !important;
}
.tl-item:hover:after {
  opacity: 0;
}
.tl-item:hover:before {
  opacity: 1;
  transform: translate3d(0, 0, 0) translateY(0);
  transition: opacity 1s ease, transform 1s ease 0.25s;
}
.tl-item:hover .tl-content {
  opacity: 1;
  transform: translateY(0);
  transition: all 0.75s ease 0.5s;
}
.tl-item:hover .tl-bg {
  filter: grayscale(0);
}

.tl-content {
  transform: translate3d(0, 0, 0) translateY(25px);
  position: relative;
  z-index: 1;
  text-align: center;
  margin: 0 1.618em;
  top: 55%;
  opacity: 0;
}
.tl-content h2 {
  font-family: "BioRhyme"; 
  text-transform: uppercase;
  color: #1779cf;
  font-size: 1.44rem;
  font-weight: normal;
}

.tl-year {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translateX(-50%) translateY(-50%);
  z-index: 1;
  border-top: 1px solid #fff;
  border-bottom: 1px solid #fff;
}
.tl-year p {
  font-family: "Pathway Gothic One", Helvetica Neue, Helvetica, Arial, sans-serif;
  font-size: 2.5rem;
  line-height: 0;
}

.tl-bg {
  transform: translate3d(0, 0, 0);
  position: absolute;
  width: 100%;
  height: 100%;
  top: 0;
  left: 0;
  background-size: cover;
  background-position: center center;
  transition: filter 0.5s ease;
  filter: grayscale(100%);
}

/*# sourceMappingURL=style11.cs.map */
