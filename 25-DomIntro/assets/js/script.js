// Root container
const root = document.getElementById("root");

// Main card
const card = document.createElement("div");
card.style.width = "360px";
card.style.background = "white";
card.style.borderRadius = "12px";
card.style.overflow = "hidden";
card.style.boxShadow = "0 4px 20px rgba(0,0,0,0.1)";
card.style.margin = "40px auto";
root.appendChild(card);

// Image box
const imgBox = document.createElement("div");
imgBox.style.position = "relative";
card.appendChild(imgBox);

// House Image
const img = document.createElement("img");
img.src = "assets/img/download.jpg"; 
img.style.width = "100%";
img.style.height = "230px";
img.style.objectFit = "cover";
imgBox.appendChild(img);

// Heart icon
const heart = document.createElement("div");
heart.innerHTML = "♡";
heart.style.position = "absolute";
heart.style.right = "15px";
heart.style.top = "15px";
heart.style.fontSize = "26px";
heart.style.color = "white";
heart.style.textShadow = "0 2px 4px rgba(0,0,0,0.3)";
imgBox.appendChild(heart);

// Content section
const content = document.createElement("div");
content.style.padding = "20px";
card.appendChild(content);

// Title
const topTitle = document.createElement("p");
topTitle.textContent = "DETACHED HOUSE • 5Y OLD";
topTitle.style.color = "#666";
topTitle.style.fontSize = "13px";
topTitle.style.marginBottom = "8px";
content.appendChild(topTitle);

// Price
const price = document.createElement("h1");
price.textContent = "$750,000";
price.style.margin = "0";
price.style.fontSize = "32px";
price.style.fontWeight = "bold";
content.appendChild(price);

// Address
const address = document.createElement("p");
address.textContent = "742 Evergreen Terrace";
address.style.color = "#666";
address.style.marginTop = "5px";
content.appendChild(address);

// Info box
const info = document.createElement("div");
info.style.display = "flex";
info.style.gap = "35px";
info.style.marginTop = "20px";
content.appendChild(info);

// Bedrooms
const bedItem = document.createElement("div");
bedItem.style.display = "flex";
bedItem.style.alignItems = "center";
bedItem.style.gap = "8px";
info.appendChild(bedItem);

const bedIcon = document.createElement("img");
bedIcon.src = "assets/img/double-bed-vector-icon-260nw-1175446654.webp";  
bedIcon.style.width = "28px";
bedIcon.style.opacity = "0.7";
bedItem.appendChild(bedIcon);

const bedText = document.createElement("span");
bedText.innerHTML = "<b>3</b> Bedrooms";
bedItem.appendChild(bedText);

// Bathrooms
const bathItem = document.createElement("div");
bathItem.style.display = "flex";
bathItem.style.alignItems = "center";
bathItem.style.gap = "8px";
info.appendChild(bathItem);

const bathIcon = document.createElement("img");
bathIcon.src = "assets/img/download (1).jpg"; 
bathIcon.style.width = "28px";
bathIcon.style.opacity = "0.7";
bathItem.appendChild(bathIcon);

const bathText = document.createElement("span");
bathText.innerHTML = "<b>2</b> Bathrooms";
bathItem.appendChild(bathText);

// Divider
const hr = document.createElement("hr");
hr.style.border = "none";
hr.style.borderTop = "1px solid #ddd";
hr.style.margin = "20px 0";
content.appendChild(hr);

// Realtor section
const realtor = document.createElement("div");
realtor.style.display = "flex";
realtor.style.alignItems = "center";
realtor.style.gap = "12px";
content.appendChild(realtor);

// Agent image
const agentImg = document.createElement("img");
agentImg.src = "assets/img/young-beautiful-girl-posing-black-leather-jacket-park_1153-8104.avif";  
agentImg.style.width = "48px";
agentImg.style.height = "48px";
agentImg.style.borderRadius = "50%";
realtor.appendChild(agentImg);

// Agent info
const agentInfo = document.createElement("div");

const agentName = document.createElement("p");
agentName.textContent = "Tiffany Heffner";
agentName.style.margin = "0";
agentName.style.fontWeight = "bold";
agentInfo.appendChild(agentName);

const agentPhone = document.createElement("p");
agentPhone.textContent = "(555) 555-4321";
agentPhone.style.margin = "0";
agentPhone.style.fontSize = "14px";
agentPhone.style.color = "#666";
agentInfo.appendChild(agentPhone);

realtor.appendChild(agentInfo);
